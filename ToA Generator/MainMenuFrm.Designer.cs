namespace ToA_Generator
{
    partial class MainMenuFrm
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
            this.WeatherBtn = new System.Windows.Forms.Button();
            this.DisplayTxtBox = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // WeatherBtn
            // 
            this.WeatherBtn.Location = new System.Drawing.Point(12, 10);
            this.WeatherBtn.Name = "WeatherBtn";
            this.WeatherBtn.Size = new System.Drawing.Size(75, 23);
            this.WeatherBtn.TabIndex = 0;
            this.WeatherBtn.Text = "Weather";
            this.WeatherBtn.UseVisualStyleBackColor = true;
            this.WeatherBtn.Click += new System.EventHandler(this.WeatherBtn_Click);
            // 
            // DisplayTxtBox
            // 
            this.DisplayTxtBox.Location = new System.Drawing.Point(461, 10);
            this.DisplayTxtBox.Multiline = true;
            this.DisplayTxtBox.Name = "DisplayTxtBox";
            this.DisplayTxtBox.Size = new System.Drawing.Size(367, 537);
            this.DisplayTxtBox.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // MainMenuFrm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 561);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DisplayTxtBox);
            this.Controls.Add(this.WeatherBtn);
            this.Name = "MainMenuFrm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Tomb of Annihilation Random Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button WeatherBtn;
        private System.Windows.Forms.TextBox DisplayTxtBox;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

