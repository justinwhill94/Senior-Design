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
            this.panel1 = new System.Windows.Forms.Panel();
            this.WelcomeMsg2 = new System.Windows.Forms.Label();
            this.WelcomeMsg1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.NoPlay = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.WithPlay = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.UserFileNameLabel = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Image = global::GUI_Project.Properties.Resources.MeasuredSolutionsLogo;
            this.Logo.Location = new System.Drawing.Point(12, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(360, 80);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(297, 229);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.WelcomeMsg2);
            this.panel1.Controls.Add(this.WelcomeMsg1);
            this.panel1.Location = new System.Drawing.Point(12, 111);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 109);
            this.panel1.TabIndex = 3;
            // 
            // WelcomeMsg2
            // 
            this.WelcomeMsg2.AutoSize = true;
            this.WelcomeMsg2.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeMsg2.Location = new System.Drawing.Point(3, 16);
            this.WelcomeMsg2.Name = "WelcomeMsg2";
            this.WelcomeMsg2.Size = new System.Drawing.Size(172, 16);
            this.WelcomeMsg2.TabIndex = 1;
            this.WelcomeMsg2.Text = "Plese hit Next to continue!";
            // 
            // WelcomeMsg1
            // 
            this.WelcomeMsg1.AutoSize = true;
            this.WelcomeMsg1.BackColor = System.Drawing.Color.White;
            this.WelcomeMsg1.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeMsg1.Location = new System.Drawing.Point(3, 0);
            this.WelcomeMsg1.Name = "WelcomeMsg1";
            this.WelcomeMsg1.Size = new System.Drawing.Size(348, 16);
            this.WelcomeMsg1.TabIndex = 0;
            this.WelcomeMsg1.Text = "Welcome to Measured Soltion\'s Paino Scroll Converter!";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Azure;
            this.panel3.Controls.Add(this.NoPlay);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.WithPlay);
            this.panel3.Location = new System.Drawing.Point(12, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 125);
            this.panel3.TabIndex = 4;
            this.panel3.Visible = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(297, 229);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Visible = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // NoPlay
            // 
            this.NoPlay.AutoSize = true;
            this.NoPlay.Location = new System.Drawing.Point(97, 35);
            this.NoPlay.Name = "NoPlay";
            this.NoPlay.Size = new System.Drawing.Size(39, 17);
            this.NoPlay.TabIndex = 4;
            this.NoPlay.TabStop = true;
            this.NoPlay.Text = "No";
            this.NoPlay.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AR JULIAN", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Would you like to convert the file with playback?";
            // 
            // WithPlay
            // 
            this.WithPlay.AutoSize = true;
            this.WithPlay.Location = new System.Drawing.Point(6, 35);
            this.WithPlay.Name = "WithPlay";
            this.WithPlay.Size = new System.Drawing.Size(43, 17);
            this.WithPlay.TabIndex = 3;
            this.WithPlay.TabStop = true;
            this.WithPlay.Text = "Yes";
            this.WithPlay.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.UserFileNameLabel);
            this.panel2.Controls.Add(this.Search);
            this.panel2.Location = new System.Drawing.Point(12, 98);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(360, 125);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("AR JULIAN", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(307, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Please select the file you would like to convert";
            // 
            // UserFileNameLabel
            // 
            this.UserFileNameLabel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.UserFileNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.UserFileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserFileNameLabel.Location = new System.Drawing.Point(6, 55);
            this.UserFileNameLabel.Name = "UserFileNameLabel";
            this.UserFileNameLabel.Size = new System.Drawing.Size(351, 23);
            this.UserFileNameLabel.TabIndex = 1;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(282, 96);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 23);
            this.Search.TabIndex = 0;
            this.Search.Text = "Open";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Azure;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(11, 98);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(360, 125);
            this.panel4.TabIndex = 5;
            this.panel4.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("AR JULIAN", 9F);
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thank you for using the Measured Solutions File Converter!";
            // 
            // MainGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.NextButton);
            this.Name = "MainGui";
            this.Text = "Piano Scroll Converter";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label WelcomeMsg2;
        private System.Windows.Forms.Label WelcomeMsg1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton NoPlay;
        private System.Windows.Forms.RadioButton WithPlay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Label UserFileNameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
    }
}

