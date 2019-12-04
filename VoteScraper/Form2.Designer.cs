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
            this.DumpertUrlText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ReadMouseClickiesButton = new System.Windows.Forms.Button();
            this.ExecuteMouseClickiesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LoadedMouseClickiesTextbox = new System.Windows.Forms.TextBox();
            this.SaveMouseClickiesButton = new System.Windows.Forms.Button();
            this.LoadMouseClickiesButton = new System.Windows.Forms.Button();
            this.CounterLabel = new System.Windows.Forms.Label();
            this.DumpertActiesLabel = new System.Windows.Forms.Label();
            this.TorReloadLabel = new System.Windows.Forms.Label();
            this.TorReloadButton = new System.Windows.Forms.Button();
            this.TorCheckIpLabel = new System.Windows.Forms.Label();
            this.TorCheckIpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DumpertUrlText
            // 
            this.DumpertUrlText.Location = new System.Drawing.Point(23, 40);
            this.DumpertUrlText.Name = "DumpertUrlText";
            this.DumpertUrlText.Size = new System.Drawing.Size(492, 31);
            this.DumpertUrlText.TabIndex = 0;
            this.DumpertUrlText.Text = "https://www.dumpert.nl/item/6855811_0c30d07e";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dumpert URL";
            // 
            // ReadMouseClickiesButton
            // 
            this.ReadMouseClickiesButton.Location = new System.Drawing.Point(18, 93);
            this.ReadMouseClickiesButton.Name = "ReadMouseClickiesButton";
            this.ReadMouseClickiesButton.Size = new System.Drawing.Size(404, 69);
            this.ReadMouseClickiesButton.TabIndex = 4;
            this.ReadMouseClickiesButton.Text = "Lees muis klikjes";
            this.ReadMouseClickiesButton.UseVisualStyleBackColor = true;
            this.ReadMouseClickiesButton.Click += new System.EventHandler(this.ReadMouseClickies_Click);
            // 
            // ExecuteMouseClickiesButton
            // 
            this.ExecuteMouseClickiesButton.Location = new System.Drawing.Point(565, 329);
            this.ExecuteMouseClickiesButton.Name = "ExecuteMouseClickiesButton";
            this.ExecuteMouseClickiesButton.Size = new System.Drawing.Size(335, 69);
            this.ExecuteMouseClickiesButton.TabIndex = 5;
            this.ExecuteMouseClickiesButton.Text = "Voer muis klikjes uit";
            this.ExecuteMouseClickiesButton.UseVisualStyleBackColor = true;
            this.ExecuteMouseClickiesButton.Click += new System.EventHandler(this.ExecuteMouseClickies_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ingeladen muis klikjes";
            // 
            // LoadedMouseClickiesTextbox
            // 
            this.LoadedMouseClickiesTextbox.Enabled = false;
            this.LoadedMouseClickiesTextbox.Location = new System.Drawing.Point(23, 279);
            this.LoadedMouseClickiesTextbox.Multiline = true;
            this.LoadedMouseClickiesTextbox.Name = "LoadedMouseClickiesTextbox";
            this.LoadedMouseClickiesTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LoadedMouseClickiesTextbox.Size = new System.Drawing.Size(338, 341);
            this.LoadedMouseClickiesTextbox.TabIndex = 7;
            // 
            // SaveMouseClickiesButton
            // 
            this.SaveMouseClickiesButton.Location = new System.Drawing.Point(18, 168);
            this.SaveMouseClickiesButton.Name = "SaveMouseClickiesButton";
            this.SaveMouseClickiesButton.Size = new System.Drawing.Size(404, 69);
            this.SaveMouseClickiesButton.TabIndex = 8;
            this.SaveMouseClickiesButton.Text = "Sla muis klikjes op";
            this.SaveMouseClickiesButton.UseVisualStyleBackColor = true;
            this.SaveMouseClickiesButton.Click += new System.EventHandler(this.SaveMouseClickiesButton_Click);
            // 
            // LoadMouseClickiesButton
            // 
            this.LoadMouseClickiesButton.Location = new System.Drawing.Point(565, 40);
            this.LoadMouseClickiesButton.Name = "LoadMouseClickiesButton";
            this.LoadMouseClickiesButton.Size = new System.Drawing.Size(335, 69);
            this.LoadMouseClickiesButton.TabIndex = 9;
            this.LoadMouseClickiesButton.Text = "Inladen: Dumpert Vote";
            this.LoadMouseClickiesButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadMouseClickiesButton.UseVisualStyleBackColor = true;
            this.LoadMouseClickiesButton.Click += new System.EventHandler(this.LoadMouseClickiesButton_Click);
            // 
            // CounterLabel
            // 
            this.CounterLabel.AutoSize = true;
            this.CounterLabel.Location = new System.Drawing.Point(37, 650);
            this.CounterLabel.Name = "CounterLabel";
            this.CounterLabel.Size = new System.Drawing.Size(85, 25);
            this.CounterLabel.TabIndex = 10;
            this.CounterLabel.Text = "[Status]";
            // 
            // DumpertActiesLabel
            // 
            this.DumpertActiesLabel.AutoSize = true;
            this.DumpertActiesLabel.Location = new System.Drawing.Point(928, 59);
            this.DumpertActiesLabel.Name = "DumpertActiesLabel";
            this.DumpertActiesLabel.Size = new System.Drawing.Size(0, 25);
            this.DumpertActiesLabel.TabIndex = 11;
            // 
            // TorReloadLabel
            // 
            this.TorReloadLabel.AutoSize = true;
            this.TorReloadLabel.Location = new System.Drawing.Point(928, 145);
            this.TorReloadLabel.Name = "TorReloadLabel";
            this.TorReloadLabel.Size = new System.Drawing.Size(0, 25);
            this.TorReloadLabel.TabIndex = 13;
            // 
            // TorReloadButton
            // 
            this.TorReloadButton.Location = new System.Drawing.Point(565, 126);
            this.TorReloadButton.Name = "TorReloadButton";
            this.TorReloadButton.Size = new System.Drawing.Size(335, 69);
            this.TorReloadButton.TabIndex = 12;
            this.TorReloadButton.Text = "Inladen: Tor reload";
            this.TorReloadButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TorReloadButton.UseVisualStyleBackColor = true;
            this.TorReloadButton.Click += new System.EventHandler(this.TorReloadButton_Click);
            // 
            // TorCheckIpLabel
            // 
            this.TorCheckIpLabel.AutoSize = true;
            this.TorCheckIpLabel.Location = new System.Drawing.Point(928, 229);
            this.TorCheckIpLabel.Name = "TorCheckIpLabel";
            this.TorCheckIpLabel.Size = new System.Drawing.Size(0, 25);
            this.TorCheckIpLabel.TabIndex = 15;
            // 
            // TorCheckIpButton
            // 
            this.TorCheckIpButton.Location = new System.Drawing.Point(565, 210);
            this.TorCheckIpButton.Name = "TorCheckIpButton";
            this.TorCheckIpButton.Size = new System.Drawing.Size(335, 69);
            this.TorCheckIpButton.TabIndex = 14;
            this.TorCheckIpButton.Text = "Inladen: Check IP adres";
            this.TorCheckIpButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TorCheckIpButton.UseVisualStyleBackColor = true;
            this.TorCheckIpButton.Click += new System.EventHandler(this.TorCheckIpButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 1181);
            this.Controls.Add(this.TorCheckIpLabel);
            this.Controls.Add(this.TorCheckIpButton);
            this.Controls.Add(this.TorReloadLabel);
            this.Controls.Add(this.TorReloadButton);
            this.Controls.Add(this.DumpertActiesLabel);
            this.Controls.Add(this.CounterLabel);
            this.Controls.Add(this.LoadMouseClickiesButton);
            this.Controls.Add(this.SaveMouseClickiesButton);
            this.Controls.Add(this.LoadedMouseClickiesTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExecuteMouseClickiesButton);
            this.Controls.Add(this.ReadMouseClickiesButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DumpertUrlText);
            this.Name = "Form2";
            this.Text = "Muisklikjes automatiseren / The Vote Scraper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DumpertUrlText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReadMouseClickiesButton;
        private System.Windows.Forms.Button ExecuteMouseClickiesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoadedMouseClickiesTextbox;
        private System.Windows.Forms.Button SaveMouseClickiesButton;
        private System.Windows.Forms.Button LoadMouseClickiesButton;
        private System.Windows.Forms.Label CounterLabel;
        private System.Windows.Forms.Label DumpertActiesLabel;
        private System.Windows.Forms.Label TorReloadLabel;
        private System.Windows.Forms.Button TorReloadButton;
        private System.Windows.Forms.Label TorCheckIpLabel;
        private System.Windows.Forms.Button TorCheckIpButton;
    }
}