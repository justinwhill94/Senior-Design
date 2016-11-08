namespace GUI_Project
{
    partial class MainGui
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
            this.RunButton = new System.Windows.Forms.Button();
            this.MainUIPanel = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.AudioPlaybackCheckBox = new System.Windows.Forms.CheckBox();
            this.VideoPlaybackCheckBox = new System.Windows.Forms.CheckBox();
            this.DestOpenButton = new System.Windows.Forms.Button();
            this.UserDestFilePath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserSourceFilePath = new System.Windows.Forms.Label();
            this.SourceOpenButton = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.MainUIPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(471, 392);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(75, 23);
            this.RunButton.TabIndex = 2;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // MainUIPanel
            // 
            this.MainUIPanel.BackColor = System.Drawing.Color.Azure;
            this.MainUIPanel.Controls.Add(this.checkBox3);
            this.MainUIPanel.Controls.Add(this.AudioPlaybackCheckBox);
            this.MainUIPanel.Controls.Add(this.VideoPlaybackCheckBox);
            this.MainUIPanel.Controls.Add(this.DestOpenButton);
            this.MainUIPanel.Controls.Add(this.UserDestFilePath);
            this.MainUIPanel.Controls.Add(this.label1);
            this.MainUIPanel.Controls.Add(this.label3);
            this.MainUIPanel.Controls.Add(this.UserSourceFilePath);
            this.MainUIPanel.Controls.Add(this.SourceOpenButton);
            this.MainUIPanel.Location = new System.Drawing.Point(12, 98);
            this.MainUIPanel.Name = "MainUIPanel";
            this.MainUIPanel.Size = new System.Drawing.Size(534, 288);
            this.MainUIPanel.TabIndex = 2;
            this.MainUIPanel.Visible = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 215);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(110, 17);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Note Visualization";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // AudioPlaybackCheckBox
            // 
            this.AudioPlaybackCheckBox.AutoSize = true;
            this.AudioPlaybackCheckBox.Location = new System.Drawing.Point(6, 191);
            this.AudioPlaybackCheckBox.Name = "AudioPlaybackCheckBox";
            this.AudioPlaybackCheckBox.Size = new System.Drawing.Size(100, 17);
            this.AudioPlaybackCheckBox.TabIndex = 7;
            this.AudioPlaybackCheckBox.Text = "Audio Playback";
            this.AudioPlaybackCheckBox.UseVisualStyleBackColor = true;
            // 
            // VideoPlaybackCheckBox
            // 
            this.VideoPlaybackCheckBox.AutoSize = true;
            this.VideoPlaybackCheckBox.Location = new System.Drawing.Point(6, 167);
            this.VideoPlaybackCheckBox.Name = "VideoPlaybackCheckBox";
            this.VideoPlaybackCheckBox.Size = new System.Drawing.Size(100, 17);
            this.VideoPlaybackCheckBox.TabIndex = 6;
            this.VideoPlaybackCheckBox.Text = "Video Playback";
            this.VideoPlaybackCheckBox.UseVisualStyleBackColor = true;
            // 
            // DestOpenButton
            // 
            this.DestOpenButton.Location = new System.Drawing.Point(440, 128);
            this.DestOpenButton.Name = "DestOpenButton";
            this.DestOpenButton.Size = new System.Drawing.Size(75, 23);
            this.DestOpenButton.TabIndex = 5;
            this.DestOpenButton.Text = "Open";
            this.DestOpenButton.UseVisualStyleBackColor = true;
            this.DestOpenButton.Click += new System.EventHandler(this.DestOpenButton_Click);
            // 
            // UserDestFilePath
            // 
            this.UserDestFilePath.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.UserDestFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserDestFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDestFilePath.Location = new System.Drawing.Point(6, 128);
            this.UserDestFilePath.Name = "UserDestFilePath";
            this.UserDestFilePath.Size = new System.Drawing.Size(411, 23);
            this.UserDestFilePath.TabIndex = 4;
            this.UserDestFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please select the destination of your output file(s)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Please select the file you would like to convert";
            // 
            // UserSourceFilePath
            // 
            this.UserSourceFilePath.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.UserSourceFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserSourceFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSourceFilePath.Location = new System.Drawing.Point(6, 55);
            this.UserSourceFilePath.Name = "UserSourceFilePath";
            this.UserSourceFilePath.Size = new System.Drawing.Size(411, 23);
            this.UserSourceFilePath.TabIndex = 1;
            this.UserSourceFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SourceOpenButton
            // 
            this.SourceOpenButton.Location = new System.Drawing.Point(440, 55);
            this.SourceOpenButton.Name = "SourceOpenButton";
            this.SourceOpenButton.Size = new System.Drawing.Size(75, 23);
            this.SourceOpenButton.TabIndex = 0;
            this.SourceOpenButton.Text = "Open";
            this.SourceOpenButton.UseVisualStyleBackColor = true;
            this.SourceOpenButton.Click += new System.EventHandler(this.Search_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::GUI_Project.Properties.Resources.MeasuredSolutionsLogo;
            this.Logo.Location = new System.Drawing.Point(96, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(360, 80);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // MainGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(558, 427);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.MainUIPanel);
            this.Controls.Add(this.RunButton);
            this.Name = "MainGui";
            this.Text = "Piano Scroll Converter";
            this.MainUIPanel.ResumeLayout(false);
            this.MainUIPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Panel MainUIPanel;
        private System.Windows.Forms.Button SourceOpenButton;
        private System.Windows.Forms.Label UserSourceFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DestOpenButton;
        private System.Windows.Forms.Label UserDestFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox VideoPlaybackCheckBox;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox AudioPlaybackCheckBox;
    }
}

