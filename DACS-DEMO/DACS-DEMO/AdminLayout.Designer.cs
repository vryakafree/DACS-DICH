namespace DACS_DEMO
{
    partial class AdminLayout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLayout));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnmofile = new System.Windows.Forms.ToolStripButton();
            this.btnupload = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.btnhome = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnmofile,
            this.btnupload,
            this.btnhome});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(791, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnmofile
            // 
            this.btnmofile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnmofile.Image = ((System.Drawing.Image)(resources.GetObject("btnmofile.Image")));
            this.btnmofile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnmofile.Name = "btnmofile";
            this.btnmofile.Size = new System.Drawing.Size(23, 22);
            this.btnmofile.Text = "Mở file";
            this.btnmofile.Click += new System.EventHandler(this.btnmofile_Click);
            // 
            // btnupload
            // 
            this.btnupload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnupload.Image = ((System.Drawing.Image)(resources.GetObject("btnupload.Image")));
            this.btnupload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(23, 22);
            this.btnupload.Text = "Upload file";
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Dock = System.Windows.Forms.DockStyle.Left;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(0, 25);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(378, 428);
            this.axAcroPDF1.TabIndex = 1;
            // 
            // btnhome
            // 
            this.btnhome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnhome.Image = ((System.Drawing.Image)(resources.GetObject("btnhome.Image")));
            this.btnhome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(23, 22);
            this.btnhome.Text = "Trang Chủ";
            // 
            // AdminLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 453);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "AdminLayout";
            this.Text = "Trang Quản Lý";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnmofile;
        private System.Windows.Forms.ToolStripButton btnupload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.ToolStripButton btnhome;
    }
}