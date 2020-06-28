namespace DACS_DEMO
{
    partial class AppLayout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppLayout));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menubar = new System.Windows.Forms.ToolStripButton();
            this.btnuser = new System.Windows.Forms.ToolStripButton();
            this.btnchat = new System.Windows.Forms.ToolStripButton();
            this.btntimkiem = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nghethuatnhanvanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.luatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.thuocsuckhoeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.khoahoctoanhocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox4 = new System.Windows.Forms.ToolStripComboBox();
            this.khoahocxahoiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox5 = new System.Windows.Forms.ToolStripComboBox();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.combotimkiem = new System.Windows.Forms.ComboBox();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(8);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menubar,
            this.btnuser,
            this.btnchat,
            this.btntimkiem});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(52, 619);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // menubar
            // 
            this.menubar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menubar.Image = global::DACS_DEMO.Properties.Resources.Icon_128x1282;
            this.menubar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(50, 24);
            this.menubar.Text = "Danh Mục";
            this.menubar.MouseEnter += new System.EventHandler(this.menubar_MouseEnter);
            // 
            // btnuser
            // 
            this.btnuser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnuser.Image = global::DACS_DEMO.Properties.Resources.Icon_128x128;
            this.btnuser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnuser.Name = "btnuser";
            this.btnuser.Size = new System.Drawing.Size(50, 24);
            this.btnuser.Text = "Đăng Nhập/Đăng Kí";
            this.btnuser.Click += new System.EventHandler(this.btnuser_Click);
            // 
            // btnchat
            // 
            this.btnchat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnchat.Image = global::DACS_DEMO.Properties.Resources.Icon_128x1284;
            this.btnchat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnchat.Name = "btnchat";
            this.btnchat.Size = new System.Drawing.Size(50, 24);
            this.btnchat.Text = "Chat";
            // 
            // btntimkiem
            // 
            this.btntimkiem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btntimkiem.Image = global::DACS_DEMO.Properties.Resources.Icon_64x64;
            this.btntimkiem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(50, 24);
            this.btntimkiem.Text = "Tìm Kiếm";
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nghethuatnhanvanToolStripMenuItem,
            this.luatToolStripMenuItem,
            this.thuocsuckhoeToolStripMenuItem,
            this.khoahoctoanhocToolStripMenuItem,
            this.khoahocxahoiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(52, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(269, 619);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            this.menuStrip1.MouseEnter += new System.EventHandler(this.menuStrip1_MouseEnter);
            this.menuStrip1.MouseLeave += new System.EventHandler(this.menuStrip1_MouseLeave);
            // 
            // nghethuatnhanvanToolStripMenuItem
            // 
            this.nghethuatnhanvanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.nghethuatnhanvanToolStripMenuItem.Name = "nghethuatnhanvanToolStripMenuItem";
            this.nghethuatnhanvanToolStripMenuItem.Size = new System.Drawing.Size(263, 24);
            this.nghethuatnhanvanToolStripMenuItem.Text = "Các ngành nghệ thuật và nhân văn";
            this.nghethuatnhanvanToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // luatToolStripMenuItem
            // 
            this.luatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.luatToolStripMenuItem.Name = "luatToolStripMenuItem";
            this.luatToolStripMenuItem.Size = new System.Drawing.Size(263, 24);
            this.luatToolStripMenuItem.Text = "Luật";
            this.luatToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 28);
            // 
            // thuocsuckhoeToolStripMenuItem
            // 
            this.thuocsuckhoeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox3});
            this.thuocsuckhoeToolStripMenuItem.Name = "thuocsuckhoeToolStripMenuItem";
            this.thuocsuckhoeToolStripMenuItem.Size = new System.Drawing.Size(263, 24);
            this.thuocsuckhoeToolStripMenuItem.Text = "Thuốc và sức khoẻ";
            this.thuocsuckhoeToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 28);
            // 
            // khoahoctoanhocToolStripMenuItem
            // 
            this.khoahoctoanhocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox4});
            this.khoahoctoanhocToolStripMenuItem.Name = "khoahoctoanhocToolStripMenuItem";
            this.khoahoctoanhocToolStripMenuItem.Size = new System.Drawing.Size(263, 24);
            this.khoahoctoanhocToolStripMenuItem.Text = "Khoa học toán học";
            this.khoahoctoanhocToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripComboBox4
            // 
            this.toolStripComboBox4.Name = "toolStripComboBox4";
            this.toolStripComboBox4.Size = new System.Drawing.Size(121, 28);
            // 
            // khoahocxahoiToolStripMenuItem
            // 
            this.khoahocxahoiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox5});
            this.khoahocxahoiToolStripMenuItem.Name = "khoahocxahoiToolStripMenuItem";
            this.khoahocxahoiToolStripMenuItem.Size = new System.Drawing.Size(263, 24);
            this.khoahocxahoiToolStripMenuItem.Text = "Khoa học xã hội";
            this.khoahocxahoiToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripComboBox5
            // 
            this.toolStripComboBox5.Name = "toolStripComboBox5";
            this.toolStripComboBox5.Size = new System.Drawing.Size(121, 28);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(273, 12);
            this.axAcroPDF1.Margin = new System.Windows.Forms.Padding(4);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(393, 479);
            this.axAcroPDF1.TabIndex = 2;
            // 
            // combotimkiem
            // 
            this.combotimkiem.FormattingEnabled = true;
            this.combotimkiem.Location = new System.Drawing.Point(56, 105);
            this.combotimkiem.Margin = new System.Windows.Forms.Padding(4);
            this.combotimkiem.Name = "combotimkiem";
            this.combotimkiem.Size = new System.Drawing.Size(160, 24);
            this.combotimkiem.TabIndex = 3;
            this.combotimkiem.Visible = false;
            // 
            // AppLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 619);
            this.Controls.Add(this.combotimkiem);
            this.Controls.Add(this.axAcroPDF1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AppLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DEMO";
            this.Load += new System.EventHandler(this.AppLayout_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem luatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thuocsuckhoeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoahoctoanhocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoahocxahoiToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnuser;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
        private System.Windows.Forms.ToolStripButton btnchat;
        private System.Windows.Forms.ToolStripButton menubar;
        private System.Windows.Forms.ToolStripButton btntimkiem;
        private System.Windows.Forms.ComboBox combotimkiem;
        private System.Windows.Forms.ToolStripMenuItem nghethuatnhanvanToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox4;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox5;
    }
}

