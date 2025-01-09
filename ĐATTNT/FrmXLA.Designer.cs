namespace ĐATTNT
{
    partial class FrmXLA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmXLA));
            this.pBLoad = new System.Windows.Forms.PictureBox();
            this.pBADXL = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnEnhance = new System.Windows.Forms.Button();
            this.btnBinarize = new System.Windows.Forms.Button();
            this.btnThinning = new System.Windows.Forms.Button();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.soSánhVânTayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnLoad = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSave = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pBLoad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBADXL)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBLoad
            // 
            this.pBLoad.Location = new System.Drawing.Point(94, 94);
            this.pBLoad.Name = "pBLoad";
            this.pBLoad.Size = new System.Drawing.Size(226, 279);
            this.pBLoad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBLoad.TabIndex = 0;
            this.pBLoad.TabStop = false;
            // 
            // pBADXL
            // 
            this.pBADXL.Location = new System.Drawing.Point(453, 94);
            this.pBADXL.Name = "pBADXL";
            this.pBADXL.Size = new System.Drawing.Size(226, 279);
            this.pBADXL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBADXL.TabIndex = 1;
            this.pBADXL.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(89, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ảnh Gốc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(448, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ảnh Đã Xử Lý";
            // 
            // btnProcess
            // 
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnProcess.Location = new System.Drawing.Point(49, 398);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(102, 32);
            this.btnProcess.TabIndex = 5;
            this.btnProcess.Text = "Chuẩn hóa";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnEnhance
            // 
            this.btnEnhance.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnEnhance.Location = new System.Drawing.Point(177, 398);
            this.btnEnhance.Name = "btnEnhance";
            this.btnEnhance.Size = new System.Drawing.Size(123, 32);
            this.btnEnhance.TabIndex = 6;
            this.btnEnhance.Text = "Tăng Cường";
            this.btnEnhance.UseVisualStyleBackColor = true;
            this.btnEnhance.Click += new System.EventHandler(this.btnEnhance_Click);
            // 
            // btnBinarize
            // 
            this.btnBinarize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBinarize.Location = new System.Drawing.Point(324, 398);
            this.btnBinarize.Name = "btnBinarize";
            this.btnBinarize.Size = new System.Drawing.Size(102, 32);
            this.btnBinarize.TabIndex = 7;
            this.btnBinarize.Text = "Nhị Phân";
            this.btnBinarize.UseVisualStyleBackColor = true;
            this.btnBinarize.Click += new System.EventHandler(this.btnBinarize_Click);
            // 
            // btnThinning
            // 
            this.btnThinning.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThinning.Location = new System.Drawing.Point(453, 398);
            this.btnThinning.Name = "btnThinning";
            this.btnThinning.Size = new System.Drawing.Size(102, 32);
            this.btnThinning.TabIndex = 8;
            this.btnThinning.Text = "Làm Mỏng";
            this.btnThinning.UseVisualStyleBackColor = true;
            this.btnThinning.Click += new System.EventHandler(this.btnThinning_Click);
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnViewDetails.Location = new System.Drawing.Point(575, 398);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(144, 32);
            this.btnViewDetails.TabIndex = 9;
            this.btnViewDetails.Text = "Rút trích đặc trưng";
            this.btnViewDetails.UseVisualStyleBackColor = true;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soSánhVânTayToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(762, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // soSánhVânTayToolStripMenuItem
            // 
            this.soSánhVânTayToolStripMenuItem.Name = "soSánhVânTayToolStripMenuItem";
            this.soSánhVânTayToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.soSánhVânTayToolStripMenuItem.Text = "So Sánh Vân Tay";
            this.soSánhVânTayToolStripMenuItem.Click += new System.EventHandler(this.soSánhVânTayToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnLoad,
            this.toolStripBtnSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(762, 27);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnLoad
            // 
            this.toolStripBtnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnLoad.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnLoad.Image")));
            this.toolStripBtnLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnLoad.Name = "toolStripBtnLoad";
            this.toolStripBtnLoad.Size = new System.Drawing.Size(29, 24);
            this.toolStripBtnLoad.Text = "Mở ảnh";
            this.toolStripBtnLoad.Click += new System.EventHandler(this.toolStripBtnLoad_Click);
            // 
            // toolStripBtnSave
            // 
            this.toolStripBtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSave.Image")));
            this.toolStripBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSave.Name = "toolStripBtnSave";
            this.toolStripBtnSave.Size = new System.Drawing.Size(29, 24);
            this.toolStripBtnSave.Text = "Lưu ảnh";
            this.toolStripBtnSave.Click += new System.EventHandler(this.toolStripBtnSave_Click);
            // 
            // FrmXLA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 454);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnViewDetails);
            this.Controls.Add(this.btnThinning);
            this.Controls.Add(this.btnBinarize);
            this.Controls.Add(this.btnEnhance);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBADXL);
            this.Controls.Add(this.pBLoad);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmXLA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xử Lý Vân Tay";
            this.Load += new System.EventHandler(this.FrmXLA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBLoad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBADXL)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBLoad;
        private System.Windows.Forms.PictureBox pBADXL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Button btnEnhance;
        private System.Windows.Forms.Button btnBinarize;
        private System.Windows.Forms.Button btnThinning;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem soSánhVânTayToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnLoad;
        private System.Windows.Forms.ToolStripButton toolStripBtnSave;
    }
}