namespace compressorX
{
    partial class compress_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(compress_Form));
            this.Top_panel = new System.Windows.Forms.Panel();
            this.icon_box = new System.Windows.Forms.PictureBox();
            this.title_LB = new System.Windows.Forms.Label();
            this.minimized_BTN = new System.Windows.Forms.PictureBox();
            this.exit_BTN = new System.Windows.Forms.PictureBox();
            this.bottom_panel = new System.Windows.Forms.Panel();
            this.startCompressFile_BTN = new System.Windows.Forms.Button();
            this.selectFile_txtBx = new System.Windows.Forms.TextBox();
            this.selectFile_BTN = new System.Windows.Forms.Button();
            this.selectLoc_BTN = new System.Windows.Forms.Button();
            this.selectLoc_txtbx = new System.Windows.Forms.TextBox();
            this.selectFile_LBL = new System.Windows.Forms.Label();
            this.selectLoc_LBL = new System.Windows.Forms.Label();
            this.compressProgressBar = new System.Windows.Forms.ProgressBar();
            this.selectFileName_LBL = new System.Windows.Forms.Label();
            this.selectFileName_txtbx = new System.Windows.Forms.TextBox();
            this.Loading_LBL = new System.Windows.Forms.Label();
            this.Top_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimized_BTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_BTN)).BeginInit();
            this.bottom_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Top_panel
            // 
            this.Top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Top_panel.Controls.Add(this.icon_box);
            this.Top_panel.Controls.Add(this.title_LB);
            this.Top_panel.Controls.Add(this.minimized_BTN);
            this.Top_panel.Controls.Add(this.exit_BTN);
            this.Top_panel.Location = new System.Drawing.Point(-1, -1);
            this.Top_panel.Name = "Top_panel";
            this.Top_panel.Size = new System.Drawing.Size(452, 37);
            this.Top_panel.TabIndex = 4;
            this.Top_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseMoveDrag_MouseDown);
            // 
            // icon_box
            // 
            this.icon_box.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("icon_box.BackgroundImage")));
            this.icon_box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon_box.Cursor = System.Windows.Forms.Cursors.Default;
            this.icon_box.Location = new System.Drawing.Point(150, 7);
            this.icon_box.Name = "icon_box";
            this.icon_box.Size = new System.Drawing.Size(20, 20);
            this.icon_box.TabIndex = 7;
            this.icon_box.TabStop = false;
            // 
            // title_LB
            // 
            this.title_LB.AutoSize = true;
            this.title_LB.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_LB.ForeColor = System.Drawing.Color.Gainsboro;
            this.title_LB.Location = new System.Drawing.Point(171, 6);
            this.title_LB.Name = "title_LB";
            this.title_LB.Size = new System.Drawing.Size(128, 21);
            this.title_LB.TabIndex = 6;
            this.title_LB.Text = "File Compressor";
            // 
            // minimized_BTN
            // 
            this.minimized_BTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimized_BTN.BackgroundImage")));
            this.minimized_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimized_BTN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minimized_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimized_BTN.Location = new System.Drawing.Point(392, 6);
            this.minimized_BTN.Name = "minimized_BTN";
            this.minimized_BTN.Size = new System.Drawing.Size(25, 25);
            this.minimized_BTN.TabIndex = 5;
            this.minimized_BTN.TabStop = false;
            this.minimized_BTN.Click += new System.EventHandler(this.minimized_BTN_Click);
            // 
            // exit_BTN
            // 
            this.exit_BTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exit_BTN.BackgroundImage")));
            this.exit_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exit_BTN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.exit_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_BTN.Location = new System.Drawing.Point(421, 6);
            this.exit_BTN.Name = "exit_BTN";
            this.exit_BTN.Size = new System.Drawing.Size(25, 25);
            this.exit_BTN.TabIndex = 4;
            this.exit_BTN.TabStop = false;
            this.exit_BTN.Click += new System.EventHandler(this.exit_BTN_Click);
            // 
            // bottom_panel
            // 
            this.bottom_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.bottom_panel.Controls.Add(this.startCompressFile_BTN);
            this.bottom_panel.Location = new System.Drawing.Point(-1, 363);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.Size = new System.Drawing.Size(452, 80);
            this.bottom_panel.TabIndex = 5;
            // 
            // startCompressFile_BTN
            // 
            this.startCompressFile_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.startCompressFile_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.startCompressFile_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startCompressFile_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.startCompressFile_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.startCompressFile_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.startCompressFile_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startCompressFile_BTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.startCompressFile_BTN.ForeColor = System.Drawing.Color.White;
            this.startCompressFile_BTN.Image = ((System.Drawing.Image)(resources.GetObject("startCompressFile_BTN.Image")));
            this.startCompressFile_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startCompressFile_BTN.Location = new System.Drawing.Point(114, 25);
            this.startCompressFile_BTN.Name = "startCompressFile_BTN";
            this.startCompressFile_BTN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.startCompressFile_BTN.Size = new System.Drawing.Size(224, 32);
            this.startCompressFile_BTN.TabIndex = 87;
            this.startCompressFile_BTN.Text = "Start Compressing";
            this.startCompressFile_BTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.startCompressFile_BTN.UseVisualStyleBackColor = false;
            this.startCompressFile_BTN.Click += new System.EventHandler(this.startCompressFile_BTN_Click);
            // 
            // selectFile_txtBx
            // 
            this.selectFile_txtBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.selectFile_txtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectFile_txtBx.Enabled = false;
            this.selectFile_txtBx.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.selectFile_txtBx.ForeColor = System.Drawing.Color.Gainsboro;
            this.selectFile_txtBx.Location = new System.Drawing.Point(12, 89);
            this.selectFile_txtBx.Multiline = true;
            this.selectFile_txtBx.Name = "selectFile_txtBx";
            this.selectFile_txtBx.Size = new System.Drawing.Size(319, 32);
            this.selectFile_txtBx.TabIndex = 6;
            this.selectFile_txtBx.WordWrap = false;
            // 
            // selectFile_BTN
            // 
            this.selectFile_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.selectFile_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.selectFile_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectFile_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.selectFile_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.selectFile_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.selectFile_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectFile_BTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.selectFile_BTN.ForeColor = System.Drawing.Color.White;
            this.selectFile_BTN.Image = ((System.Drawing.Image)(resources.GetObject("selectFile_BTN.Image")));
            this.selectFile_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selectFile_BTN.Location = new System.Drawing.Point(337, 89);
            this.selectFile_BTN.Name = "selectFile_BTN";
            this.selectFile_BTN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectFile_BTN.Size = new System.Drawing.Size(101, 32);
            this.selectFile_BTN.TabIndex = 88;
            this.selectFile_BTN.Text = "Select File";
            this.selectFile_BTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.selectFile_BTN.UseVisualStyleBackColor = false;
            this.selectFile_BTN.Click += new System.EventHandler(this.selectFile_BTN_Click);
            // 
            // selectLoc_BTN
            // 
            this.selectLoc_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.selectLoc_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.selectLoc_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectLoc_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.selectLoc_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.selectLoc_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.selectLoc_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectLoc_BTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.selectLoc_BTN.ForeColor = System.Drawing.Color.White;
            this.selectLoc_BTN.Image = ((System.Drawing.Image)(resources.GetObject("selectLoc_BTN.Image")));
            this.selectLoc_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.selectLoc_BTN.Location = new System.Drawing.Point(337, 167);
            this.selectLoc_BTN.Name = "selectLoc_BTN";
            this.selectLoc_BTN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectLoc_BTN.Size = new System.Drawing.Size(101, 32);
            this.selectLoc_BTN.TabIndex = 90;
            this.selectLoc_BTN.Text = "Select";
            this.selectLoc_BTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.selectLoc_BTN.UseVisualStyleBackColor = false;
            this.selectLoc_BTN.Click += new System.EventHandler(this.selectLoc_BTN_Click);
            // 
            // selectLoc_txtbx
            // 
            this.selectLoc_txtbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.selectLoc_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectLoc_txtbx.Enabled = false;
            this.selectLoc_txtbx.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.selectLoc_txtbx.ForeColor = System.Drawing.Color.Gainsboro;
            this.selectLoc_txtbx.Location = new System.Drawing.Point(12, 167);
            this.selectLoc_txtbx.Multiline = true;
            this.selectLoc_txtbx.Name = "selectLoc_txtbx";
            this.selectLoc_txtbx.Size = new System.Drawing.Size(319, 32);
            this.selectLoc_txtbx.TabIndex = 89;
            this.selectLoc_txtbx.WordWrap = false;
            // 
            // selectFile_LBL
            // 
            this.selectFile_LBL.AutoSize = true;
            this.selectFile_LBL.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.selectFile_LBL.ForeColor = System.Drawing.Color.Gainsboro;
            this.selectFile_LBL.Location = new System.Drawing.Point(12, 64);
            this.selectFile_LBL.Name = "selectFile_LBL";
            this.selectFile_LBL.Size = new System.Drawing.Size(217, 17);
            this.selectFile_LBL.TabIndex = 91;
            this.selectFile_LBL.Text = "Select a file you want to Compress";
            // 
            // selectLoc_LBL
            // 
            this.selectLoc_LBL.AutoSize = true;
            this.selectLoc_LBL.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.selectLoc_LBL.ForeColor = System.Drawing.Color.Gainsboro;
            this.selectLoc_LBL.Location = new System.Drawing.Point(12, 142);
            this.selectLoc_LBL.Name = "selectLoc_LBL";
            this.selectLoc_LBL.Size = new System.Drawing.Size(277, 17);
            this.selectLoc_LBL.TabIndex = 92;
            this.selectLoc_LBL.Text = "Select a location where you want to save file";
            // 
            // compressProgressBar
            // 
            this.compressProgressBar.Location = new System.Drawing.Point(12, 316);
            this.compressProgressBar.Name = "compressProgressBar";
            this.compressProgressBar.Size = new System.Drawing.Size(426, 21);
            this.compressProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.compressProgressBar.TabIndex = 93;
            this.compressProgressBar.UseWaitCursor = true;
            this.compressProgressBar.Visible = false;
            // 
            // selectFileName_LBL
            // 
            this.selectFileName_LBL.AutoSize = true;
            this.selectFileName_LBL.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.selectFileName_LBL.ForeColor = System.Drawing.Color.Gainsboro;
            this.selectFileName_LBL.Location = new System.Drawing.Point(12, 219);
            this.selectFileName_LBL.Name = "selectFileName_LBL";
            this.selectFileName_LBL.Size = new System.Drawing.Size(110, 17);
            this.selectFileName_LBL.TabIndex = 95;
            this.selectFileName_LBL.Text = "Enter a file name";
            // 
            // selectFileName_txtbx
            // 
            this.selectFileName_txtbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.selectFileName_txtbx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selectFileName_txtbx.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.selectFileName_txtbx.ForeColor = System.Drawing.Color.Gainsboro;
            this.selectFileName_txtbx.Location = new System.Drawing.Point(12, 244);
            this.selectFileName_txtbx.Multiline = true;
            this.selectFileName_txtbx.Name = "selectFileName_txtbx";
            this.selectFileName_txtbx.Size = new System.Drawing.Size(426, 32);
            this.selectFileName_txtbx.TabIndex = 94;
            this.selectFileName_txtbx.WordWrap = false;
            // 
            // Loading_LBL
            // 
            this.Loading_LBL.AutoSize = true;
            this.Loading_LBL.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.Loading_LBL.ForeColor = System.Drawing.Color.Gainsboro;
            this.Loading_LBL.Location = new System.Drawing.Point(131, 291);
            this.Loading_LBL.Name = "Loading_LBL";
            this.Loading_LBL.Size = new System.Drawing.Size(167, 17);
            this.Loading_LBL.TabIndex = 96;
            this.Loading_LBL.Text = "Please wait Compressing...";
            this.Loading_LBL.Visible = false;
            // 
            // compress_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(450, 442);
            this.Controls.Add(this.Loading_LBL);
            this.Controls.Add(this.selectFileName_LBL);
            this.Controls.Add(this.selectFileName_txtbx);
            this.Controls.Add(this.compressProgressBar);
            this.Controls.Add(this.selectLoc_LBL);
            this.Controls.Add(this.selectFile_LBL);
            this.Controls.Add(this.selectLoc_BTN);
            this.Controls.Add(this.selectLoc_txtbx);
            this.Controls.Add(this.selectFile_BTN);
            this.Controls.Add(this.selectFile_txtBx);
            this.Controls.Add(this.bottom_panel);
            this.Controls.Add(this.Top_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "compress_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Compressor";
            this.Top_panel.ResumeLayout(false);
            this.Top_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimized_BTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_BTN)).EndInit();
            this.bottom_panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Top_panel;
        private System.Windows.Forms.PictureBox icon_box;
        private System.Windows.Forms.Label title_LB;
        private System.Windows.Forms.PictureBox minimized_BTN;
        private System.Windows.Forms.PictureBox exit_BTN;
        private System.Windows.Forms.Panel bottom_panel;
        private System.Windows.Forms.Button startCompressFile_BTN;
        private System.Windows.Forms.TextBox selectFile_txtBx;
        private System.Windows.Forms.Button selectFile_BTN;
        private System.Windows.Forms.Button selectLoc_BTN;
        private System.Windows.Forms.TextBox selectLoc_txtbx;
        private System.Windows.Forms.Label selectFile_LBL;
        private System.Windows.Forms.Label selectLoc_LBL;
        private System.Windows.Forms.ProgressBar compressProgressBar;
        private System.Windows.Forms.Label selectFileName_LBL;
        private System.Windows.Forms.TextBox selectFileName_txtbx;
        private System.Windows.Forms.Label Loading_LBL;

    }
}