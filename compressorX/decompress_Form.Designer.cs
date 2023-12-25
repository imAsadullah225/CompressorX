namespace compressorX
{
    partial class decompress_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(decompress_Form));
            this.Top_panel = new System.Windows.Forms.Panel();
            this.icon_box = new System.Windows.Forms.PictureBox();
            this.title_LB = new System.Windows.Forms.Label();
            this.minimized_BTN = new System.Windows.Forms.PictureBox();
            this.exit_BTN = new System.Windows.Forms.PictureBox();
            this.startDecompressFile_BTN = new System.Windows.Forms.Button();
            this.bottom_panel = new System.Windows.Forms.Panel();
            this.selectLoc_LBL = new System.Windows.Forms.Label();
            this.selectFile_LBL = new System.Windows.Forms.Label();
            this.selectLoc_BTN = new System.Windows.Forms.Button();
            this.selectLoc_txtbx = new System.Windows.Forms.TextBox();
            this.selectFile_BTN = new System.Windows.Forms.Button();
            this.selectFile_txtBx = new System.Windows.Forms.TextBox();
            this.Loading_LBL = new System.Windows.Forms.Label();
            this.selectFileName_LBL = new System.Windows.Forms.Label();
            this.selectFileName_txtbx = new System.Windows.Forms.TextBox();
            this.decompressProgressBar = new System.Windows.Forms.ProgressBar();
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
            this.Top_panel.TabIndex = 5;
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
            this.title_LB.Size = new System.Drawing.Size(146, 21);
            this.title_LB.TabIndex = 6;
            this.title_LB.Text = "File Decompressor";
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
            // startDecompressFile_BTN
            // 
            this.startDecompressFile_BTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.startDecompressFile_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.startDecompressFile_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startDecompressFile_BTN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.startDecompressFile_BTN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.startDecompressFile_BTN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.startDecompressFile_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startDecompressFile_BTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.startDecompressFile_BTN.ForeColor = System.Drawing.Color.White;
            this.startDecompressFile_BTN.Image = ((System.Drawing.Image)(resources.GetObject("startDecompressFile_BTN.Image")));
            this.startDecompressFile_BTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startDecompressFile_BTN.Location = new System.Drawing.Point(114, 25);
            this.startDecompressFile_BTN.Name = "startDecompressFile_BTN";
            this.startDecompressFile_BTN.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.startDecompressFile_BTN.Size = new System.Drawing.Size(224, 32);
            this.startDecompressFile_BTN.TabIndex = 87;
            this.startDecompressFile_BTN.Text = "Start Decompressing";
            this.startDecompressFile_BTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.startDecompressFile_BTN.UseVisualStyleBackColor = false;
            this.startDecompressFile_BTN.Click += new System.EventHandler(this.startDecompressFile_BTN_Click);
            // 
            // bottom_panel
            // 
            this.bottom_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.bottom_panel.Controls.Add(this.startDecompressFile_BTN);
            this.bottom_panel.Location = new System.Drawing.Point(-1, 363);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.Size = new System.Drawing.Size(452, 80);
            this.bottom_panel.TabIndex = 6;
            // 
            // selectLoc_LBL
            // 
            this.selectLoc_LBL.AutoSize = true;
            this.selectLoc_LBL.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.selectLoc_LBL.ForeColor = System.Drawing.Color.Gainsboro;
            this.selectLoc_LBL.Location = new System.Drawing.Point(12, 142);
            this.selectLoc_LBL.Name = "selectLoc_LBL";
            this.selectLoc_LBL.Size = new System.Drawing.Size(277, 17);
            this.selectLoc_LBL.TabIndex = 98;
            this.selectLoc_LBL.Text = "Select a location where you want to save file";
            // 
            // selectFile_LBL
            // 
            this.selectFile_LBL.AutoSize = true;
            this.selectFile_LBL.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.selectFile_LBL.ForeColor = System.Drawing.Color.Gainsboro;
            this.selectFile_LBL.Location = new System.Drawing.Point(12, 64);
            this.selectFile_LBL.Name = "selectFile_LBL";
            this.selectFile_LBL.Size = new System.Drawing.Size(231, 17);
            this.selectFile_LBL.TabIndex = 97;
            this.selectFile_LBL.Text = "Select a file you want to Decompress";
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
            this.selectLoc_BTN.TabIndex = 96;
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
            this.selectLoc_txtbx.TabIndex = 95;
            this.selectLoc_txtbx.WordWrap = false;
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
            this.selectFile_BTN.TabIndex = 94;
            this.selectFile_BTN.Text = "Select File";
            this.selectFile_BTN.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.selectFile_BTN.UseVisualStyleBackColor = false;
            this.selectFile_BTN.Click += new System.EventHandler(this.selectFile_BTN_Click);
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
            this.selectFile_txtBx.TabIndex = 93;
            this.selectFile_txtBx.WordWrap = false;
            // 
            // Loading_LBL
            // 
            this.Loading_LBL.AutoSize = true;
            this.Loading_LBL.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.Loading_LBL.ForeColor = System.Drawing.Color.Gainsboro;
            this.Loading_LBL.Location = new System.Drawing.Point(131, 291);
            this.Loading_LBL.Name = "Loading_LBL";
            this.Loading_LBL.Size = new System.Drawing.Size(181, 17);
            this.Loading_LBL.TabIndex = 102;
            this.Loading_LBL.Text = "Please wait Decompressing...";
            this.Loading_LBL.Visible = false;
            // 
            // selectFileName_LBL
            // 
            this.selectFileName_LBL.AutoSize = true;
            this.selectFileName_LBL.Font = new System.Drawing.Font("Segoe UI Semibold", 9.5F, System.Drawing.FontStyle.Bold);
            this.selectFileName_LBL.ForeColor = System.Drawing.Color.Gainsboro;
            this.selectFileName_LBL.Location = new System.Drawing.Point(12, 219);
            this.selectFileName_LBL.Name = "selectFileName_LBL";
            this.selectFileName_LBL.Size = new System.Drawing.Size(110, 17);
            this.selectFileName_LBL.TabIndex = 101;
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
            this.selectFileName_txtbx.TabIndex = 100;
            this.selectFileName_txtbx.WordWrap = false;
            // 
            // decompressProgressBar
            // 
            this.decompressProgressBar.Location = new System.Drawing.Point(12, 316);
            this.decompressProgressBar.Name = "decompressProgressBar";
            this.decompressProgressBar.Size = new System.Drawing.Size(426, 21);
            this.decompressProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.decompressProgressBar.TabIndex = 99;
            this.decompressProgressBar.UseWaitCursor = true;
            this.decompressProgressBar.Visible = false;
            // 
            // decompress_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(450, 442);
            this.Controls.Add(this.Loading_LBL);
            this.Controls.Add(this.selectFileName_LBL);
            this.Controls.Add(this.selectFileName_txtbx);
            this.Controls.Add(this.decompressProgressBar);
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
            this.Name = "decompress_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Decompressor";
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
        private System.Windows.Forms.Button startDecompressFile_BTN;
        private System.Windows.Forms.Panel bottom_panel;
        private System.Windows.Forms.Label selectLoc_LBL;
        private System.Windows.Forms.Label selectFile_LBL;
        private System.Windows.Forms.Button selectLoc_BTN;
        private System.Windows.Forms.TextBox selectLoc_txtbx;
        private System.Windows.Forms.Button selectFile_BTN;
        private System.Windows.Forms.TextBox selectFile_txtBx;
        private System.Windows.Forms.Label Loading_LBL;
        private System.Windows.Forms.Label selectFileName_LBL;
        private System.Windows.Forms.TextBox selectFileName_txtbx;
        private System.Windows.Forms.ProgressBar decompressProgressBar;
    }
}