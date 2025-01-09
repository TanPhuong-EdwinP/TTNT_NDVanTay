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
using System.IO;
namespace ĐATTNT
{
    public partial class Form1 : Form
    {
        private string comparisonResult;
      

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ToolStripXLA_Click(object sender, EventArgs e)
        {
            FrmXLA frmXLA = new FrmXLA();
            frmXLA.Show();
        }
        
        private void toolStripBtnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) 
            { 
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; 
                if (openFileDialog.ShowDialog() == DialogResult.OK) 
                { 
                    pBA1.Image = Image.FromFile(openFileDialog.FileName); 
                } 
            }
        }

        private void toolStripBtnLoad2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) 
            { 
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"; 
                if (openFileDialog.ShowDialog() == DialogResult.OK) 
                { 
                    pBA2.Image = Image.FromFile(openFileDialog.FileName); 
                } 
            }
        }

        private Dictionary<string, Dictionary<string, int>> CompareFingerprints(Mat image1, Mat image2)
        {
            Dictionary<string, int> details1 = new Dictionary<string, int>
    {
        { "Points X", 0 },
        { "Points Y", 0 }
    };

            Dictionary<string, int> details2 = new Dictionary<string, int>
    {
        { "Points X", 0 },
        { "Points Y", 0 }
    };

            for (int i = 0; i < image1.Rows; i++)
            {
                for (int j = 0; j < image1.Cols; j++)
                {
                    byte p = image1.Get<byte>(i, j);
                    if (p == 255)
                    {
                        if (i % 2 == 0 && j % 2 == 0)
                        {
                            details1["Points X"]++;
                        }
                        else
                        {
                            details1["Points Y"]++;
                        }
                    }
                }
            }

            for (int i = 0; i < image2.Rows; i++)
            {
                for (int j = 0; j < image2.Cols; j++)
                {
                    byte p = image2.Get<byte>(i, j);
                    if (p == 255)
                    {
                        if (i % 2 == 0 && j % 2 == 0)
                        {
                            details2["Points X"]++;
                        }
                        else
                        {
                            details2["Points Y"]++;
                        }
                    }
                }
            }

            return new Dictionary<string, Dictionary<string, int>>
    {
        { "Fingerprint 1", details1 },
        { "Fingerprint 2", details2 }
    };
        }
        private async void toolStripBtnCompare_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Chương trình đang chạy...";
            toolStripProgressBar.Value = 0;

            Mat image1 = BitmapConverter.ToMat(new Bitmap(pBA1.Image));
            Mat image2 = BitmapConverter.ToMat(new Bitmap(pBA2.Image)); 

            var details = await Task.Run(() => CompareFingerprints(image1, image2));

            toolStripStatusLabel1.Text = "Chương trình đã hoàn thành";
            toolStripProgressBar.Value = 100;

            bool areSimilar = AreFingerprintsSimilar(details["Fingerprint 1"], details["Fingerprint 2"]);

            StringBuilder resultMessage = new StringBuilder();
            if (areSimilar)
            {
                resultMessage.AppendLine("Vân tay giống nhau.");
            }
            else
            {
                resultMessage.AppendLine("Vân tay khác nhau.");
            }
            resultMessage.AppendLine($"Vân tay 1 - Points X: {details["Fingerprint 1"]["Points X"]}, Points Y: {details["Fingerprint 1"]["Points Y"]}");
            resultMessage.AppendLine($"Vân tay 2 - Points X: {details["Fingerprint 2"]["Points X"]}, Points Y: {details["Fingerprint 2"]["Points Y"]}");

            comparisonResult = resultMessage.ToString();

            MessageBox.Show(comparisonResult, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        
        private bool AreFingerprintsSimilar(Dictionary<string, int> details1, Dictionary<string, int> details2)
        {

            int minPointsX = 5;
            int minPointsY = 5;
            int maxDifference = 3;

            return details1["Points X"] > minPointsX && details1["Points Y"] > minPointsY &&
                   details2["Points X"] > minPointsX && details2["Points Y"] > minPointsY &&
                   Math.Abs(details1["Points X"] - details2["Points X"]) <= maxDifference &&
                   Math.Abs(details1["Points Y"] - details2["Points Y"]) <= maxDifference;
        }

        private void toolStripBtnSaveResult_Click(object sender, EventArgs e)
        {
            if (pBA1.Image != null && pBA2.Image != null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    int width = (pBA1.Image.Width + pBA2.Image.Width) * 2;
                    int height = (Math.Max(pBA1.Image.Height, pBA2.Image.Height) + 50) * 2;
                    Bitmap combinedImage = new Bitmap(width, height);

                    using (Graphics g = Graphics.FromImage(combinedImage))
                    {
                        g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                        g.DrawImage(pBA1.Image, 0, 0, pBA1.Image.Width * 2, pBA1.Image.Height * 2);
                        g.DrawImage(pBA2.Image, pBA1.Image.Width * 2, 0, pBA2.Image.Width * 2, pBA2.Image.Height * 2);

                        Font fontCaption = new Font("Arial", 10, FontStyle.Bold); 
                        Brush brushCaption = new SolidBrush(Color.Black); 
                        g.DrawString("Ảnh 1", fontCaption, brushCaption, new PointF(20, 10)); 
                        g.DrawString("Ảnh 2", fontCaption, brushCaption, new PointF(pBA1.Image.Width * 2 + 20, 10));

                        Font font = new Font("Arial", 10);
                        Brush brush = new SolidBrush(Color.White);
                        g.DrawString(comparisonResult, font, brush, new PointF(10, (Math.Max(pBA1.Image.Height, pBA2.Image.Height) * 2) + 10));
                    }

                    combinedImage.Save(saveFileDialog.FileName);
                }
            }
            else
            {
                MessageBox.Show("Không có ảnh nào để lưu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
    }
}

