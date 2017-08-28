namespace SimpleColorTool
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.hoverAlphaScrollBar = new System.Windows.Forms.HScrollBar();
            this.hoverRedScrollBar = new System.Windows.Forms.HScrollBar();
            this.hoverGreenScrollBar = new System.Windows.Forms.HScrollBar();
            this.hoverRgbLabel = new System.Windows.Forms.Label();
            this.hoverArgbLabel = new System.Windows.Forms.Label();
            this.hoverHexLabel1 = new System.Windows.Forms.Label();
            this.hoverHexLabel2 = new System.Windows.Forms.Label();
            this.hoverBlueScrollBar = new System.Windows.Forms.HScrollBar();
            this.copyHoveredColorRgbBtn = new System.Windows.Forms.Button();
            this.copyHoveredColorArgbBtn = new System.Windows.Forms.Button();
            this.copyHoveredColorHexBtn1 = new System.Windows.Forms.Button();
            this.copyHoveredColorHexBtn2 = new System.Windows.Forms.Button();
            this.hoverAlphaLabel = new System.Windows.Forms.Label();
            this.hoverRedLabel = new System.Windows.Forms.Label();
            this.hoverGreenLabel = new System.Windows.Forms.Label();
            this.hoverBlueLabel = new System.Windows.Forms.Label();
            this.hoverGroupLabel = new System.Windows.Forms.Label();
            this.clickGroupLabel = new System.Windows.Forms.Label();
            this.clickAlphaScrollBar = new System.Windows.Forms.HScrollBar();
            this.clickRedScrollBar = new System.Windows.Forms.HScrollBar();
            this.clickGreenScrollBar = new System.Windows.Forms.HScrollBar();
            this.clickRgbLabel = new System.Windows.Forms.Label();
            this.clickArgbLabel = new System.Windows.Forms.Label();
            this.clickHexLabel1 = new System.Windows.Forms.Label();
            this.clickHexLabel2 = new System.Windows.Forms.Label();
            this.clickBlueScrollBar = new System.Windows.Forms.HScrollBar();
            this.copyClickedColorRgbBtn = new System.Windows.Forms.Button();
            this.copyClickedColorArgbBtn = new System.Windows.Forms.Button();
            this.copyClickedColorHexBtn1 = new System.Windows.Forms.Button();
            this.copyClickedColorHexBtn2 = new System.Windows.Forms.Button();
            this.clickAlphaLabel = new System.Windows.Forms.Label();
            this.clickRedLabel = new System.Windows.Forms.Label();
            this.clickGreenLabel = new System.Windows.Forms.Label();
            this.clickBlueLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.clickColorPreview = new System.Windows.Forms.PictureBox();
            this.colorWheelPicture = new System.Windows.Forms.PictureBox();
            this.hoverColorPreview = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clickColorPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorWheelPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoverColorPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // hoverAlphaScrollBar
            // 
            this.hoverAlphaScrollBar.Location = new System.Drawing.Point(1025, 43);
            this.hoverAlphaScrollBar.Maximum = 255;
            this.hoverAlphaScrollBar.Name = "hoverAlphaScrollBar";
            this.hoverAlphaScrollBar.Size = new System.Drawing.Size(291, 21);
            this.hoverAlphaScrollBar.TabIndex = 2;
            // 
            // hoverRedScrollBar
            // 
            this.hoverRedScrollBar.Location = new System.Drawing.Point(1025, 73);
            this.hoverRedScrollBar.Maximum = 255;
            this.hoverRedScrollBar.Name = "hoverRedScrollBar";
            this.hoverRedScrollBar.Size = new System.Drawing.Size(291, 21);
            this.hoverRedScrollBar.TabIndex = 3;
            // 
            // hoverGreenScrollBar
            // 
            this.hoverGreenScrollBar.Location = new System.Drawing.Point(1025, 106);
            this.hoverGreenScrollBar.Maximum = 255;
            this.hoverGreenScrollBar.Name = "hoverGreenScrollBar";
            this.hoverGreenScrollBar.Size = new System.Drawing.Size(291, 21);
            this.hoverGreenScrollBar.TabIndex = 4;
            // 
            // hoverRgbLabel
            // 
            this.hoverRgbLabel.AutoSize = true;
            this.hoverRgbLabel.Location = new System.Drawing.Point(1038, 178);
            this.hoverRgbLabel.Name = "hoverRgbLabel";
            this.hoverRgbLabel.Size = new System.Drawing.Size(135, 17);
            this.hoverRgbLabel.TabIndex = 9;
            this.hoverRgbLabel.Text = "hovered color in rgb";
            // 
            // hoverArgbLabel
            // 
            this.hoverArgbLabel.AutoSize = true;
            this.hoverArgbLabel.Location = new System.Drawing.Point(1038, 210);
            this.hoverArgbLabel.Name = "hoverArgbLabel";
            this.hoverArgbLabel.Size = new System.Drawing.Size(143, 17);
            this.hoverArgbLabel.TabIndex = 10;
            this.hoverArgbLabel.Text = "hovered color in argb";
            // 
            // hoverHexLabel1
            // 
            this.hoverHexLabel1.AutoSize = true;
            this.hoverHexLabel1.Location = new System.Drawing.Point(1038, 241);
            this.hoverHexLabel1.Name = "hoverHexLabel1";
            this.hoverHexLabel1.Size = new System.Drawing.Size(176, 17);
            this.hoverHexLabel1.TabIndex = 11;
            this.hoverHexLabel1.Text = "hovered color in hex with #";
            // 
            // hoverHexLabel2
            // 
            this.hoverHexLabel2.AutoSize = true;
            this.hoverHexLabel2.Location = new System.Drawing.Point(1038, 273);
            this.hoverHexLabel2.Name = "hoverHexLabel2";
            this.hoverHexLabel2.Size = new System.Drawing.Size(196, 17);
            this.hoverHexLabel2.TabIndex = 12;
            this.hoverHexLabel2.Text = "hovered color in hex without #";
            // 
            // hoverBlueScrollBar
            // 
            this.hoverBlueScrollBar.Location = new System.Drawing.Point(1025, 139);
            this.hoverBlueScrollBar.Maximum = 255;
            this.hoverBlueScrollBar.Name = "hoverBlueScrollBar";
            this.hoverBlueScrollBar.Size = new System.Drawing.Size(291, 21);
            this.hoverBlueScrollBar.TabIndex = 14;
            // 
            // copyHoveredColorRgbBtn
            // 
            this.copyHoveredColorRgbBtn.Location = new System.Drawing.Point(1241, 174);
            this.copyHoveredColorRgbBtn.Name = "copyHoveredColorRgbBtn";
            this.copyHoveredColorRgbBtn.Size = new System.Drawing.Size(75, 25);
            this.copyHoveredColorRgbBtn.TabIndex = 1;
            this.copyHoveredColorRgbBtn.Text = "copy";
            this.copyHoveredColorRgbBtn.UseVisualStyleBackColor = true;
            this.copyHoveredColorRgbBtn.Click += new System.EventHandler(this.Copy_Button_Click);
            // 
            // copyHoveredColorArgbBtn
            // 
            this.copyHoveredColorArgbBtn.Location = new System.Drawing.Point(1241, 206);
            this.copyHoveredColorArgbBtn.Name = "copyHoveredColorArgbBtn";
            this.copyHoveredColorArgbBtn.Size = new System.Drawing.Size(75, 25);
            this.copyHoveredColorArgbBtn.TabIndex = 2;
            this.copyHoveredColorArgbBtn.Text = "copy";
            this.copyHoveredColorArgbBtn.UseVisualStyleBackColor = true;
            this.copyHoveredColorArgbBtn.Click += new System.EventHandler(this.Copy_Button_Click);
            // 
            // copyHoveredColorHexBtn1
            // 
            this.copyHoveredColorHexBtn1.Location = new System.Drawing.Point(1241, 237);
            this.copyHoveredColorHexBtn1.Name = "copyHoveredColorHexBtn1";
            this.copyHoveredColorHexBtn1.Size = new System.Drawing.Size(75, 25);
            this.copyHoveredColorHexBtn1.TabIndex = 3;
            this.copyHoveredColorHexBtn1.Text = "copy";
            this.copyHoveredColorHexBtn1.UseVisualStyleBackColor = true;
            this.copyHoveredColorHexBtn1.Click += new System.EventHandler(this.Copy_Button_Click);
            // 
            // copyHoveredColorHexBtn2
            // 
            this.copyHoveredColorHexBtn2.Location = new System.Drawing.Point(1241, 269);
            this.copyHoveredColorHexBtn2.Name = "copyHoveredColorHexBtn2";
            this.copyHoveredColorHexBtn2.Size = new System.Drawing.Size(75, 25);
            this.copyHoveredColorHexBtn2.TabIndex = 4;
            this.copyHoveredColorHexBtn2.Text = "copy";
            this.copyHoveredColorHexBtn2.UseVisualStyleBackColor = true;
            this.copyHoveredColorHexBtn2.Click += new System.EventHandler(this.Copy_Button_Click);
            // 
            // hoverAlphaLabel
            // 
            this.hoverAlphaLabel.AutoSize = true;
            this.hoverAlphaLabel.Location = new System.Drawing.Point(980, 47);
            this.hoverAlphaLabel.Name = "hoverAlphaLabel";
            this.hoverAlphaLabel.Size = new System.Drawing.Size(44, 17);
            this.hoverAlphaLabel.TabIndex = 19;
            this.hoverAlphaLabel.Text = "Alpha";
            // 
            // hoverRedLabel
            // 
            this.hoverRedLabel.AutoSize = true;
            this.hoverRedLabel.Location = new System.Drawing.Point(980, 77);
            this.hoverRedLabel.Name = "hoverRedLabel";
            this.hoverRedLabel.Size = new System.Drawing.Size(34, 17);
            this.hoverRedLabel.TabIndex = 20;
            this.hoverRedLabel.Text = "Red";
            // 
            // hoverGreenLabel
            // 
            this.hoverGreenLabel.AutoSize = true;
            this.hoverGreenLabel.Location = new System.Drawing.Point(980, 110);
            this.hoverGreenLabel.Name = "hoverGreenLabel";
            this.hoverGreenLabel.Size = new System.Drawing.Size(48, 17);
            this.hoverGreenLabel.TabIndex = 21;
            this.hoverGreenLabel.Text = "Green";
            // 
            // hoverBlueLabel
            // 
            this.hoverBlueLabel.AutoSize = true;
            this.hoverBlueLabel.Location = new System.Drawing.Point(980, 143);
            this.hoverBlueLabel.Name = "hoverBlueLabel";
            this.hoverBlueLabel.Size = new System.Drawing.Size(36, 17);
            this.hoverBlueLabel.TabIndex = 22;
            this.hoverBlueLabel.Text = "Blue";
            // 
            // hoverGroupLabel
            // 
            this.hoverGroupLabel.AutoSize = true;
            this.hoverGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.hoverGroupLabel.Location = new System.Drawing.Point(719, 19);
            this.hoverGroupLabel.Name = "hoverGroupLabel";
            this.hoverGroupLabel.Size = new System.Drawing.Size(217, 20);
            this.hoverGroupLabel.TabIndex = 24;
            this.hoverGroupLabel.Text = "MOUSE HOVER COLOR";
            // 
            // clickGroupLabel
            // 
            this.clickGroupLabel.AutoSize = true;
            this.clickGroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.clickGroupLabel.Location = new System.Drawing.Point(719, 333);
            this.clickGroupLabel.Name = "clickGroupLabel";
            this.clickGroupLabel.Size = new System.Drawing.Size(186, 20);
            this.clickGroupLabel.TabIndex = 25;
            this.clickGroupLabel.Text = "LAST CLICK COLOR";
            // 
            // clickAlphaScrollBar
            // 
            this.clickAlphaScrollBar.Location = new System.Drawing.Point(1025, 357);
            this.clickAlphaScrollBar.Maximum = 255;
            this.clickAlphaScrollBar.Name = "clickAlphaScrollBar";
            this.clickAlphaScrollBar.Size = new System.Drawing.Size(291, 21);
            this.clickAlphaScrollBar.TabIndex = 26;
            // 
            // clickRedScrollBar
            // 
            this.clickRedScrollBar.Location = new System.Drawing.Point(1025, 387);
            this.clickRedScrollBar.Maximum = 255;
            this.clickRedScrollBar.Name = "clickRedScrollBar";
            this.clickRedScrollBar.Size = new System.Drawing.Size(291, 21);
            this.clickRedScrollBar.TabIndex = 27;
            // 
            // clickGreenScrollBar
            // 
            this.clickGreenScrollBar.Location = new System.Drawing.Point(1025, 420);
            this.clickGreenScrollBar.Maximum = 255;
            this.clickGreenScrollBar.Name = "clickGreenScrollBar";
            this.clickGreenScrollBar.Size = new System.Drawing.Size(291, 21);
            this.clickGreenScrollBar.TabIndex = 28;
            // 
            // clickRgbLabel
            // 
            this.clickRgbLabel.AutoSize = true;
            this.clickRgbLabel.Location = new System.Drawing.Point(1038, 492);
            this.clickRgbLabel.Name = "clickRgbLabel";
            this.clickRgbLabel.Size = new System.Drawing.Size(126, 17);
            this.clickRgbLabel.TabIndex = 29;
            this.clickRgbLabel.Text = "clicked color in rgb";
            // 
            // clickArgbLabel
            // 
            this.clickArgbLabel.AutoSize = true;
            this.clickArgbLabel.Location = new System.Drawing.Point(1038, 524);
            this.clickArgbLabel.Name = "clickArgbLabel";
            this.clickArgbLabel.Size = new System.Drawing.Size(134, 17);
            this.clickArgbLabel.TabIndex = 30;
            this.clickArgbLabel.Text = "clicked color in argb";
            // 
            // clickHexLabel1
            // 
            this.clickHexLabel1.AutoSize = true;
            this.clickHexLabel1.Location = new System.Drawing.Point(1038, 555);
            this.clickHexLabel1.Name = "clickHexLabel1";
            this.clickHexLabel1.Size = new System.Drawing.Size(167, 17);
            this.clickHexLabel1.TabIndex = 31;
            this.clickHexLabel1.Text = "clicked color in hex with #";
            // 
            // clickHexLabel2
            // 
            this.clickHexLabel2.AutoSize = true;
            this.clickHexLabel2.Location = new System.Drawing.Point(1038, 587);
            this.clickHexLabel2.Name = "clickHexLabel2";
            this.clickHexLabel2.Size = new System.Drawing.Size(187, 17);
            this.clickHexLabel2.TabIndex = 32;
            this.clickHexLabel2.Text = "clicked color in hex without #";
            // 
            // clickBlueScrollBar
            // 
            this.clickBlueScrollBar.Location = new System.Drawing.Point(1025, 453);
            this.clickBlueScrollBar.Maximum = 255;
            this.clickBlueScrollBar.Name = "clickBlueScrollBar";
            this.clickBlueScrollBar.Size = new System.Drawing.Size(291, 21);
            this.clickBlueScrollBar.TabIndex = 34;
            // 
            // copyClickedColorRgbBtn
            // 
            this.copyClickedColorRgbBtn.Location = new System.Drawing.Point(1241, 488);
            this.copyClickedColorRgbBtn.Name = "copyClickedColorRgbBtn";
            this.copyClickedColorRgbBtn.Size = new System.Drawing.Size(75, 25);
            this.copyClickedColorRgbBtn.TabIndex = 5;
            this.copyClickedColorRgbBtn.Text = "copy";
            this.copyClickedColorRgbBtn.UseVisualStyleBackColor = true;
            this.copyClickedColorRgbBtn.Click += new System.EventHandler(this.Copy_Button_Click);
            // 
            // copyClickedColorArgbBtn
            // 
            this.copyClickedColorArgbBtn.Location = new System.Drawing.Point(1241, 520);
            this.copyClickedColorArgbBtn.Name = "copyClickedColorArgbBtn";
            this.copyClickedColorArgbBtn.Size = new System.Drawing.Size(75, 25);
            this.copyClickedColorArgbBtn.TabIndex = 6;
            this.copyClickedColorArgbBtn.Text = "copy";
            this.copyClickedColorArgbBtn.UseVisualStyleBackColor = true;
            this.copyClickedColorArgbBtn.Click += new System.EventHandler(this.Copy_Button_Click);
            // 
            // copyClickedColorHexBtn1
            // 
            this.copyClickedColorHexBtn1.Location = new System.Drawing.Point(1241, 551);
            this.copyClickedColorHexBtn1.Name = "copyClickedColorHexBtn1";
            this.copyClickedColorHexBtn1.Size = new System.Drawing.Size(75, 25);
            this.copyClickedColorHexBtn1.TabIndex = 7;
            this.copyClickedColorHexBtn1.Text = "copy";
            this.copyClickedColorHexBtn1.UseVisualStyleBackColor = true;
            this.copyClickedColorHexBtn1.Click += new System.EventHandler(this.Copy_Button_Click);
            // 
            // copyClickedColorHexBtn2
            // 
            this.copyClickedColorHexBtn2.Location = new System.Drawing.Point(1241, 583);
            this.copyClickedColorHexBtn2.Name = "copyClickedColorHexBtn2";
            this.copyClickedColorHexBtn2.Size = new System.Drawing.Size(75, 25);
            this.copyClickedColorHexBtn2.TabIndex = 8;
            this.copyClickedColorHexBtn2.Text = "copy";
            this.copyClickedColorHexBtn2.UseVisualStyleBackColor = true;
            this.copyClickedColorHexBtn2.Click += new System.EventHandler(this.Copy_Button_Click);
            // 
            // clickAlphaLabel
            // 
            this.clickAlphaLabel.AutoSize = true;
            this.clickAlphaLabel.Location = new System.Drawing.Point(978, 361);
            this.clickAlphaLabel.Name = "clickAlphaLabel";
            this.clickAlphaLabel.Size = new System.Drawing.Size(44, 17);
            this.clickAlphaLabel.TabIndex = 39;
            this.clickAlphaLabel.Text = "Alpha";
            // 
            // clickRedLabel
            // 
            this.clickRedLabel.AutoSize = true;
            this.clickRedLabel.Location = new System.Drawing.Point(980, 391);
            this.clickRedLabel.Name = "clickRedLabel";
            this.clickRedLabel.Size = new System.Drawing.Size(34, 17);
            this.clickRedLabel.TabIndex = 40;
            this.clickRedLabel.Text = "Red";
            // 
            // clickGreenLabel
            // 
            this.clickGreenLabel.AutoSize = true;
            this.clickGreenLabel.Location = new System.Drawing.Point(978, 424);
            this.clickGreenLabel.Name = "clickGreenLabel";
            this.clickGreenLabel.Size = new System.Drawing.Size(48, 17);
            this.clickGreenLabel.TabIndex = 41;
            this.clickGreenLabel.Text = "Green";
            // 
            // clickBlueLabel
            // 
            this.clickBlueLabel.AutoSize = true;
            this.clickBlueLabel.Location = new System.Drawing.Point(980, 457);
            this.clickBlueLabel.Name = "clickBlueLabel";
            this.clickBlueLabel.Size = new System.Drawing.Size(36, 17);
            this.clickBlueLabel.TabIndex = 42;
            this.clickBlueLabel.Text = "Blue";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Enabled = false;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 631);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1322, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // clickColorPreview
            // 
            this.clickColorPreview.Location = new System.Drawing.Point(723, 357);
            this.clickColorPreview.Margin = new System.Windows.Forms.Padding(4);
            this.clickColorPreview.Name = "clickColorPreview";
            this.clickColorPreview.Size = new System.Drawing.Size(250, 256);
            this.clickColorPreview.TabIndex = 33;
            this.clickColorPreview.TabStop = false;
            // 
            // colorWheelPicture
            // 
            this.colorWheelPicture.BackColor = System.Drawing.Color.Transparent;
            this.colorWheelPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.colorWheelPicture.Cursor = System.Windows.Forms.Cursors.Default;
            this.colorWheelPicture.Image = global::SimpleColorTool.Properties.Resources.color_wheel_500;
            this.colorWheelPicture.Location = new System.Drawing.Point(12, 12);
            this.colorWheelPicture.Name = "colorWheelPicture";
            this.colorWheelPicture.Size = new System.Drawing.Size(500, 500);
            this.colorWheelPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.colorWheelPicture.TabIndex = 23;
            this.colorWheelPicture.TabStop = false;
            this.colorWheelPicture.Click += new System.EventHandler(this.ColorWheel_Click);
            this.colorWheelPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ColorWheel_MouseMove);
            // 
            // hoverColorPreview
            // 
            this.hoverColorPreview.Location = new System.Drawing.Point(723, 43);
            this.hoverColorPreview.Margin = new System.Windows.Forms.Padding(4);
            this.hoverColorPreview.Name = "hoverColorPreview";
            this.hoverColorPreview.Size = new System.Drawing.Size(250, 256);
            this.hoverColorPreview.TabIndex = 13;
            this.hoverColorPreview.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1322, 653);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.clickBlueLabel);
            this.Controls.Add(this.clickGreenLabel);
            this.Controls.Add(this.clickRedLabel);
            this.Controls.Add(this.clickAlphaLabel);
            this.Controls.Add(this.copyClickedColorHexBtn2);
            this.Controls.Add(this.copyClickedColorHexBtn1);
            this.Controls.Add(this.copyClickedColorArgbBtn);
            this.Controls.Add(this.copyClickedColorRgbBtn);
            this.Controls.Add(this.clickBlueScrollBar);
            this.Controls.Add(this.clickColorPreview);
            this.Controls.Add(this.clickHexLabel2);
            this.Controls.Add(this.clickHexLabel1);
            this.Controls.Add(this.clickArgbLabel);
            this.Controls.Add(this.clickRgbLabel);
            this.Controls.Add(this.clickGreenScrollBar);
            this.Controls.Add(this.clickRedScrollBar);
            this.Controls.Add(this.clickAlphaScrollBar);
            this.Controls.Add(this.clickGroupLabel);
            this.Controls.Add(this.hoverGroupLabel);
            this.Controls.Add(this.colorWheelPicture);
            this.Controls.Add(this.hoverBlueLabel);
            this.Controls.Add(this.hoverGreenLabel);
            this.Controls.Add(this.hoverRedLabel);
            this.Controls.Add(this.hoverAlphaLabel);
            this.Controls.Add(this.copyHoveredColorHexBtn2);
            this.Controls.Add(this.copyHoveredColorHexBtn1);
            this.Controls.Add(this.copyHoveredColorArgbBtn);
            this.Controls.Add(this.copyHoveredColorRgbBtn);
            this.Controls.Add(this.hoverBlueScrollBar);
            this.Controls.Add(this.hoverColorPreview);
            this.Controls.Add(this.hoverHexLabel2);
            this.Controls.Add(this.hoverHexLabel1);
            this.Controls.Add(this.hoverArgbLabel);
            this.Controls.Add(this.hoverRgbLabel);
            this.Controls.Add(this.hoverGreenScrollBar);
            this.Controls.Add(this.hoverRedScrollBar);
            this.Controls.Add(this.hoverAlphaScrollBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1340, 700);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleColorTool";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clickColorPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorWheelPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoverColorPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.HScrollBar hoverAlphaScrollBar;
        private System.Windows.Forms.HScrollBar hoverRedScrollBar;
        private System.Windows.Forms.HScrollBar hoverGreenScrollBar;
        private System.Windows.Forms.Label hoverRgbLabel;
        private System.Windows.Forms.Label hoverArgbLabel;
        private System.Windows.Forms.Label hoverHexLabel1;
        private System.Windows.Forms.Label hoverHexLabel2;
        private System.Windows.Forms.PictureBox hoverColorPreview;
        private System.Windows.Forms.HScrollBar hoverBlueScrollBar;
        private System.Windows.Forms.Button copyHoveredColorRgbBtn;
        private System.Windows.Forms.Button copyHoveredColorArgbBtn;
        private System.Windows.Forms.Button copyHoveredColorHexBtn1;
        private System.Windows.Forms.Button copyHoveredColorHexBtn2;
        private System.Windows.Forms.Label hoverAlphaLabel;
        private System.Windows.Forms.Label hoverRedLabel;
        private System.Windows.Forms.Label hoverGreenLabel;
        private System.Windows.Forms.Label hoverBlueLabel;
        private System.Windows.Forms.PictureBox colorWheelPicture;
        private System.Windows.Forms.Label hoverGroupLabel;
        private System.Windows.Forms.PictureBox clickColorPreview;
        private System.Windows.Forms.Label clickGroupLabel;
        private System.Windows.Forms.HScrollBar clickAlphaScrollBar;
        private System.Windows.Forms.HScrollBar clickRedScrollBar;
        private System.Windows.Forms.HScrollBar clickGreenScrollBar;
        private System.Windows.Forms.Label clickRgbLabel;
        private System.Windows.Forms.Label clickArgbLabel;
        private System.Windows.Forms.Label clickHexLabel1;
        private System.Windows.Forms.Label clickHexLabel2;
        private System.Windows.Forms.HScrollBar clickBlueScrollBar;
        private System.Windows.Forms.Button copyClickedColorRgbBtn;
        private System.Windows.Forms.Button copyClickedColorArgbBtn;
        private System.Windows.Forms.Button copyClickedColorHexBtn1;
        private System.Windows.Forms.Button copyClickedColorHexBtn2;
        private System.Windows.Forms.Label clickAlphaLabel;
        private System.Windows.Forms.Label clickRedLabel;
        private System.Windows.Forms.Label clickGreenLabel;
        private System.Windows.Forms.Label clickBlueLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

