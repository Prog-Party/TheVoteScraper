namespace VoteScraper
{
    partial class Form2
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
            this.MouseText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReadMouseClickiesButton = new System.Windows.Forms.Button();
            this.ExecuteMouseClickiesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LoadedMouseClickiesTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MouseText
            // 
            this.MouseText.Location = new System.Drawing.Point(101, 93);
            this.MouseText.Name = "MouseText";
            this.MouseText.Size = new System.Drawing.Size(249, 31);
            this.MouseText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Muis";
            // 
            // ReadMouseClickiesButton
            // 
            this.ReadMouseClickiesButton.Location = new System.Drawing.Point(12, 12);
            this.ReadMouseClickiesButton.Name = "ReadMouseClickiesButton";
            this.ReadMouseClickiesButton.Size = new System.Drawing.Size(338, 69);
            this.ReadMouseClickiesButton.TabIndex = 4;
            this.ReadMouseClickiesButton.Text = "Lees muis klikjes";
            this.ReadMouseClickiesButton.UseVisualStyleBackColor = true;
            this.ReadMouseClickiesButton.Click += new System.EventHandler(this.ReadMouseClickies_Click);
            // 
            // ExecuteMouseClickiesButton
            // 
            this.ExecuteMouseClickiesButton.Location = new System.Drawing.Point(450, 12);
            this.ExecuteMouseClickiesButton.Name = "ExecuteMouseClickiesButton";
            this.ExecuteMouseClickiesButton.Size = new System.Drawing.Size(338, 69);
            this.ExecuteMouseClickiesButton.TabIndex = 5;
            this.ExecuteMouseClickiesButton.Text = "Voer muis klikjes uit";
            this.ExecuteMouseClickiesButton.UseVisualStyleBackColor = true;
            this.ExecuteMouseClickiesButton.Click += new System.EventHandler(this.ExecuteMouseClickies_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingeladen muis klikjes";
            // 
            // LoadedMouseClickiesTextbox
            // 
            this.LoadedMouseClickiesTextbox.Enabled = false;
            this.LoadedMouseClickiesTextbox.Location = new System.Drawing.Point(18, 195);
            this.LoadedMouseClickiesTextbox.Multiline = true;
            this.LoadedMouseClickiesTextbox.Name = "LoadedMouseClickiesTextbox";
            this.LoadedMouseClickiesTextbox.Size = new System.Drawing.Size(770, 521);
            this.LoadedMouseClickiesTextbox.TabIndex = 7;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 728);
            this.Controls.Add(this.LoadedMouseClickiesTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExecuteMouseClickiesButton);
            this.Controls.Add(this.ReadMouseClickiesButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MouseText);
            this.Name = "Form2";
            this.Text = "Muisklikjes automatiseren / The Vote Scraper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MouseText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReadMouseClickiesButton;
        private System.Windows.Forms.Button ExecuteMouseClickiesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoadedMouseClickiesTextbox;
    }
}