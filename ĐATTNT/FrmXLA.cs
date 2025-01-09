using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace ĐATTNT
{
    public partial class FrmXLA : Form
    {
        public FrmXLA()
        {
            InitializeComponent();
        }

        private void FrmXLA_Load(object sender, EventArgs e)
        {

        }
        private bool isImageProcessed = false;
        private string processingType = string.Empty;
        private OpenCvSharp.Mat PreprocessImage(OpenCvSharp.Mat image)
        {
            OpenCvSharp.Mat grayImage = new OpenCvSharp.Mat();
            Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

            OpenCvSharp.Mat equalizedImage = new OpenCvSharp.Mat();
            Cv2.EqualizeHist(grayImage, equalizedImage);

            return equalizedImage;
        }

        private OpenCvSharp.Mat EnhanceImage(OpenCvSharp.Mat image)
        {
            OpenCvSharp.Mat enhancedImage = new OpenCvSharp.Mat();
            Cv2.DetailEnhance(image, enhancedImage);

            return enhancedImage;
        }

        private OpenCvSharp.Mat BinarizeImage(OpenCvSharp.Mat image, double thresholdValue = 127)
        {
            OpenCvSharp.Mat binaryImage = new OpenCvSharp.Mat();
            Cv2.Threshold(image, binaryImage, thresholdValue, 255, ThresholdTypes.Binary);

            return binaryImage;
        }

        private OpenCvSharp.Mat Thinning(OpenCvSharp.Mat image, double thresholdValue = 127)
        {
            OpenCvSharp.Mat binaryImage = new OpenCvSharp.Mat();
            Cv2.Threshold(image, binaryImage, thresholdValue, 255, ThresholdTypes.BinaryInv);

            OpenCvSharp.Mat thinnedImage = binaryImage.Clone();

            bool hasChanged;
            do
            {
                hasChanged = false;

                for (int i = 1; i < thinnedImage.Rows - 1; i++)
                {
                    for (int j = 1; j < thinnedImage.Cols - 1; j++)
                    {
                        byte p1 = thinnedImage.Get<byte>(i, j);
                        if (p1 != 0) continue;

                        byte p2 = thinnedImage.Get<byte>(i - 1, j);
                        byte p3 = thinnedImage.Get<byte>(i - 1, j + 1);
                        byte p4 = thinnedImage.Get<byte>(i, j + 1);
                        byte p5 = thinnedImage.Get<byte>(i + 1, j + 1);
                        byte p6 = thinnedImage.Get<byte>(i + 1, j);
                        byte p7 = thinnedImage.Get<byte>(i + 1, j - 1);
                        byte p8 = thinnedImage.Get<byte>(i, j - 1);
                        byte p9 = thinnedImage.Get<byte>(i - 1, j - 1);

                        int A = Convert.ToInt32(p2 == 255 && p3 == 0) + Convert.ToInt32(p3 == 255 && p4 == 0) +
                                Convert.ToInt32(p4 == 255 && p5 == 0) + Convert.ToInt32(p5 == 255 && p6 == 0) +
                                Convert.ToInt32(p6 == 255 && p7 == 0) + Convert.ToInt32(p7 == 255 && p8 == 0) +
                                Convert.ToInt32(p8 == 255 && p9 == 0) + Convert.ToInt32(p9 == 255 && p2 == 0);

                        int B = Convert.ToInt32(p2 == 0) + Convert.ToInt32(p3 == 0) + Convert.ToInt32(p4 == 0) + Convert.ToInt32(p5 == 0) +
                                Convert.ToInt32(p6 == 0) + Convert.ToInt32(p7 == 0) + Convert.ToInt32(p8 == 0) + Convert.ToInt32(p9 == 0);

                        if (A == 1 && B >= 2 && B <= 6 && (p2 * p4 * p6 == 0) && (p4 * p6 * p8 == 0))
                        {
                            thinnedImage.Set<byte>(i, j, 255);
                            hasChanged = true;
                        }
                    }
                }
            } while (hasChanged);

            return thinnedImage;
        }
        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (pBLoad.Image != null)
            {
                OpenCvSharp.Mat image = BitmapConverter.ToMat(new Bitmap(pBLoad.Image));
                OpenCvSharp.Mat preprocessedImage = PreprocessImage(image);
                pBADXL.Image = BitmapConverter.ToBitmap(preprocessedImage);
                isImageProcessed = true;
                processingType = "Chuẩn Hóa";
            }
        }

        private void btnEnhance_Click(object sender, EventArgs e)
        {
            if (pBLoad.Image != null)
            {
                OpenCvSharp.Mat image = BitmapConverter.ToMat(new Bitmap(pBLoad.Image));
                OpenCvSharp.Mat enhancedImage = EnhanceImage(image);
                pBADXL.Image = BitmapConverter.ToBitmap(enhancedImage);
                isImageProcessed = true;
                processingType = "Tăng Cường";
            }
        }

        private void btnBinarize_Click(object sender, EventArgs e)
        {
            if (pBLoad.Image != null)
            {
                OpenCvSharp.Mat image = BitmapConverter.ToMat(new Bitmap(pBLoad.Image));
                OpenCvSharp.Mat binaryImage = BinarizeImage(image);
                pBADXL.Image = BitmapConverter.ToBitmap(binaryImage);
                isImageProcessed = true;
                processingType = "Nhị phân";
            }
        }

        private void btnThinning_Click(object sender, EventArgs e)
        {
            if (pBLoad.Image != null)
            {
                OpenCvSharp.Mat image = BitmapConverter.ToMat(new Bitmap(pBLoad.Image));
                OpenCvSharp.Mat preprocessedImage = PreprocessImage(image);
                OpenCvSharp.Mat thinnedImage = Thinning(preprocessedImage, 80);
                pBADXL.Image = BitmapConverter.ToBitmap(thinnedImage);
                isImageProcessed = true;
                processingType = "Làm mỏng";
            }
        }
        private Dictionary<string, int> CountFingerPrintDetails(OpenCvSharp.Mat image)
        {
            Dictionary<string, int> details = new Dictionary<string, int>
    {
        { "Điểm kết thúc", 0 },
        { "Điểm phân nhánh", 0 }
    };

            for (int i = 1; i < image.Rows - 1; i++)
            {
                for (int j = 1; j < image.Cols - 1; j++)
                {
                    byte p1 = image.Get<byte>(i, j);
                    if (p1 == 0)
                    {
                        int count = 0;
                        if (image.Get<byte>(i - 1, j) == 255) count++;
                        if (image.Get<byte>(i + 1, j) == 255) count++;
                        if (image.Get<byte>(i, j - 1) == 255) count++;
                        if (image.Get<byte>(i, j + 1) == 255) count++;
                        if (image.Get<byte>(i - 1, j - 1) == 255) count++;
                        if (image.Get<byte>(i - 1, j + 1) == 255) count++;
                        if (image.Get<byte>(i + 1, j - 1) == 255) count++;
                        if (image.Get<byte>(i + 1, j + 1) == 255) count++;

                        if (count == 1)
                        {
                            details["Điểm kết thúc"]++;
                        }
                        else if (count > 2)
                        {
                            details["Điểm phân nhánh"]++;
                        }
                    }
                }
            }

            return details;
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (pBLoad.Image != null)
            {
                OpenCvSharp.Mat originalImage = BitmapConverter.ToMat(new Bitmap(pBLoad.Image));
                Dictionary<string, int> originalDetails = CountFingerPrintDetails(originalImage);

                OpenCvSharp.Mat processedImage = isImageProcessed ? BitmapConverter.ToMat(new Bitmap(pBADXL.Image)) : null;
                Dictionary<string, int> processedDetails = processedImage != null ? CountFingerPrintDetails(processedImage) : null;

                Form detailsForm = new Form
                {
                    Text = "Rút trích đặc trưng",
                    Size = new System.Drawing.Size(400, 140)
                };

                DataGridView dataGridView = new DataGridView
                {
                    Dock = DockStyle.Fill,
                    ColumnCount = 3,
                    ColumnHeadersVisible = true
                };
                dataGridView.Columns[0].Name = "Chi tiết";
                dataGridView.Columns[1].Name = "Số lượng (Ảnh gốc)";
                dataGridView.Columns[2].Name = "Số lượng (Ảnh đã xử lý)";

                foreach (var detail in originalDetails)
                {
                    int processedCount = processedDetails != null && processedDetails.ContainsKey(detail.Key) ? processedDetails[detail.Key] : 0;
                    dataGridView.Rows.Add(detail.Key, detail.Value, processedCount);
                }

                detailsForm.Controls.Add(dataGridView);
                detailsForm.ShowDialog();

                if (processedDetails != null)
                {
                    isImageProcessed = true;
                    processingType = "Rút trích đặc trưng";
                }
            }
        }


        private void soSánhVânTayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void toolStripBtnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pBLoad.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void toolStripBtnSave_Click(object sender, EventArgs e)
        {
            if (isImageProcessed && pBADXL.Image != null) 
            {
                if (MessageBox.Show($"Bạn có chắc muốn lưu ảnh đã xử lý với loại xử lý: {processingType}?", "Xác nhận lưu ảnh", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Bitmap originalBitmap = new Bitmap(pBADXL.Image);
                    int newHeight = originalBitmap.Height + 50;
                    Bitmap newBitmap = new Bitmap(originalBitmap.Width, newHeight);

                    using (Graphics graphics = Graphics.FromImage(newBitmap))
                    {
                        graphics.Clear(Color.White);
                        graphics.DrawImage(originalBitmap, 0, 0);
                        Font font = new Font("Arial", 10);
                        Brush brush = new SolidBrush(Color.Black);
                        PointF point = new PointF(10, originalBitmap.Height + 10);
                        graphics.DrawString(processingType, font, brush, point);
                    }

                    using (SaveFileDialog saveFileDialog = new SaveFileDialog
                    {
                        Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|PNG Image|*.png",
                        Title = "Lưu ảnh đã xử lý",
                        FileName = $"Image_{processingType.Replace(" ", "_")}"
                    })
                    {
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            newBitmap.Save(saveFileDialog.FileName);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Không có ảnh đã xử lý để lưu.", "Lỗi lưu ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}

      






