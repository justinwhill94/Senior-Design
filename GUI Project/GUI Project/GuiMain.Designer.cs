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
            this.Logo = new System.Windows.Forms.PictureBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.MainUIPanel = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.DestOpenButton = new System.Windows.Forms.Button();
            this.UserDestFilePath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserSourceFilePath = new System.Windows.Forms.Label();
            this.SourceOpenButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.MainUIPanel.SuspendLayout();
            this.SuspendLayout();
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
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(471, 392);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Run";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // MainUIPanel
            // 
            this.MainUIPanel.BackColor = System.Drawing.Color.Azure;
            this.MainUIPanel.Controls.Add(this.checkBox3);
            this.MainUIPanel.Controls.Add(this.checkBox2);
            this.MainUIPanel.Controls.Add(this.checkBox1);
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
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 191);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(100, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Audio Playback";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 167);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Video Playback";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // DestOpenButton
            // 
            this.DestOpenButton.Location = new System.Drawing.Point(440, 128);
            this.DestOpenButton.Name = "DestOpenButton";
            this.DestOpenButton.Size = new System.Drawing.Size(75, 23);
            this.DestOpenButton.TabIndex = 5;
            this.DestOpenButton.Text = "Open";
            this.DestOpenButton.UseVisualStyleBackColor = true;
            this.DestOpenButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserDestFilePath
            // 
            this.UserDestFilePath.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.UserDestFilePath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UserDestFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserDestFilePath.Location = new System.Drawing.Point(6, 128);
            this.UserDestFilePath.Name = "UserDestFilePath";
            this.UserDestFilePath.Size = new System.Drawing.Size(411, 23);
            this.UserDestFilePath.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please select the destination of your output file";
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
            this.UserSourceFilePath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UserSourceFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserSourceFilePath.Location = new System.Drawing.Point(6, 55);
            this.UserSourceFilePath.Name = "UserSourceFilePath";
            this.UserSourceFilePath.Size = new System.Drawing.Size(411, 23);
            this.UserSourceFilePath.TabIndex = 1;
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
            // MainGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(558, 427);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.MainUIPanel);
            this.Controls.Add(this.NextButton);
            this.Name = "MainGui";
            this.Text = "Piano Scroll Converter";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.MainUIPanel.ResumeLayout(false);
            this.MainUIPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Panel MainUIPanel;
        private System.Windows.Forms.Button SourceOpenButton;
        private System.Windows.Forms.Label UserSourceFilePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DestOpenButton;
        private System.Windows.Forms.Label UserDestFilePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}

