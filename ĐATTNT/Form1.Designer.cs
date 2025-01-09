namespace ĐATTNT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnSaveResult = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnLoad = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnLoad2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnCompare = new System.Windows.Forms.ToolStripButton();
            this.pBA1 = new System.Windows.Forms.PictureBox();
            this.pBA2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBA1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBA2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnSaveResult,
            this.toolStripBtnLoad,
            this.toolStripBtnLoad2,
            this.toolStripBtnCompare});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(641, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnSaveResult
            // 
            this.toolStripBtnSaveResult.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnSaveResult.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnSaveResult.Image")));
            this.toolStripBtnSaveResult.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSaveResult.Name = "toolStripBtnSaveResult";
            this.toolStripBtnSaveResult.Size = new System.Drawing.Size(29, 24);
            this.toolStripBtnSaveResult.Text = "toolStripButton4";
            this.toolStripBtnSaveResult.Click += new System.EventHandler(this.toolStripBtnSaveResult_Click);
            // 
            // toolStripBtnLoad
            // 
            this.toolStripBtnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnLoad.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnLoad.Image")));
            this.toolStripBtnLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnLoad.Name = "toolStripBtnLoad";
            this.toolStripBtnLoad.Size = new System.Drawing.Size(29, 24);
            this.toolStripBtnLoad.Text = "Mở Ảnh 1";
            this.toolStripBtnLoad.Click += new System.EventHandler(this.toolStripBtnLoad_Click);
            // 
            // toolStripBtnLoad2
            // 
            this.toolStripBtnLoad2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnLoad2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnLoad2.Image")));
            this.toolStripBtnLoad2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnLoad2.Name = "toolStripBtnLoad2";
            this.toolStripBtnLoad2.Size = new System.Drawing.Size(29, 24);
            this.toolStripBtnLoad2.Text = "Mở ảnh 2";
            this.toolStripBtnLoad2.Click += new System.EventHandler(this.toolStripBtnLoad2_Click);
            // 
            // toolStripBtnCompare
            // 
            this.toolStripBtnCompare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnCompare.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBtnCompare.Image")));
            this.toolStripBtnCompare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnCompare.Name = "toolStripBtnCompare";
            this.toolStripBtnCompare.Size = new System.Drawing.Size(29, 24);
            this.toolStripBtnCompare.Text = "So Sánh ";
            this.toolStripBtnCompare.Click += new System.EventHandler(this.toolStripBtnCompare_Click);
            // 
            // pBA1
            // 
            this.pBA1.Location = new System.Drawing.Point(94, 105);
            this.pBA1.Name = "pBA1";
            this.pBA1.Size = new System.Drawing.Size(180, 217);
            this.pBA1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBA1.TabIndex = 3;
            this.pBA1.TabStop = false;
            // 
            // pBA2
            // 
            this.pBA2.Location = new System.Drawing.Point(377, 105);
            this.pBA2.Name = "pBA2";
            this.pBA2.Size = new System.Drawing.Size(180, 217);
            this.pBA2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBA2.TabIndex = 4;
            this.pBA2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(91, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ảnh 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(374, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ảnh 2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 432);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(641, 26);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 18);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 458);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pBA2);
            this.Controls.Add(this.pBA1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "So Sánh Vân Tay";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBA1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBA2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.PictureBox pBA1;
        private System.Windows.Forms.PictureBox pBA2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton toolStripBtnLoad;
        private System.Windows.Forms.ToolStripButton toolStripBtnLoad2;
        private System.Windows.Forms.ToolStripButton toolStripBtnCompare;
        private System.Windows.Forms.ToolStripButton toolStripBtnSaveResult;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
    }
}

