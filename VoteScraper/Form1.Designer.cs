namespace VoteScraper
{
    partial class Form1
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
            this.VoteUpButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.KudosTodayLabel = new System.Windows.Forms.Label();
            this.ViewsTodayLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.KudosTotalLabel = new System.Windows.Forms.Label();
            this.ViewsTotalLabel = new System.Windows.Forms.Label();
            this.KudosTodayValue = new System.Windows.Forms.Label();
            this.KudosTotalValue = new System.Windows.Forms.Label();
            this.ViewsTodayValue = new System.Windows.Forms.Label();
            this.ViewsTotalValue = new System.Windows.Forms.Label();
            this.DescriptionValue = new System.Windows.Forms.Label();
            this.TitleValue = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // VoteUpButton
            // 
            this.VoteUpButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.VoteUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VoteUpButton.Location = new System.Drawing.Point(184, 426);
            this.VoteUpButton.Margin = new System.Windows.Forms.Padding(2);
            this.VoteUpButton.Name = "VoteUpButton";
            this.VoteUpButton.Size = new System.Drawing.Size(177, 64);
            this.VoteUpButton.TabIndex = 0;
            this.VoteUpButton.Text = "Vote UP!";
            this.VoteUpButton.UseVisualStyleBackColor = false;
            this.VoteUpButton.Click += new System.EventHandler(this.VoteUpButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(223, 495);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(93, 46);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(166, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Dumpert url";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TitleLabel.Location = new System.Drawing.Point(13, 10);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(46, 20);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Title";
            // 
            // KudosTodayLabel
            // 
            this.KudosTodayLabel.AutoSize = true;
            this.KudosTodayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KudosTodayLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.KudosTodayLabel.Location = new System.Drawing.Point(13, 10);
            this.KudosTodayLabel.Name = "KudosTodayLabel";
            this.KudosTodayLabel.Size = new System.Drawing.Size(112, 20);
            this.KudosTodayLabel.TabIndex = 4;
            this.KudosTodayLabel.Text = "Kudos today";
            // 
            // ViewsTodayLabel
            // 
            this.ViewsTodayLabel.AutoSize = true;
            this.ViewsTodayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewsTodayLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ViewsTodayLabel.Location = new System.Drawing.Point(13, 84);
            this.ViewsTodayLabel.Name = "ViewsTodayLabel";
            this.ViewsTodayLabel.Size = new System.Drawing.Size(110, 20);
            this.ViewsTodayLabel.TabIndex = 5;
            this.ViewsTodayLabel.Text = "Views today";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(54, 72);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(480, 26);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "https://www.dumpert.nl/item/6855811_0c30d07e";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DescriptionLabel.Location = new System.Drawing.Point(13, 47);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(106, 20);
            this.DescriptionLabel.TabIndex = 8;
            this.DescriptionLabel.Text = "Description";
            // 
            // KudosTotalLabel
            // 
            this.KudosTotalLabel.AutoSize = true;
            this.KudosTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KudosTotalLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.KudosTotalLabel.Location = new System.Drawing.Point(13, 47);
            this.KudosTotalLabel.Name = "KudosTotalLabel";
            this.KudosTotalLabel.Size = new System.Drawing.Size(104, 20);
            this.KudosTotalLabel.TabIndex = 9;
            this.KudosTotalLabel.Text = "Kudos total";
            // 
            // ViewsTotalLabel
            // 
            this.ViewsTotalLabel.AutoSize = true;
            this.ViewsTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewsTotalLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ViewsTotalLabel.Location = new System.Drawing.Point(13, 121);
            this.ViewsTotalLabel.Name = "ViewsTotalLabel";
            this.ViewsTotalLabel.Size = new System.Drawing.Size(102, 20);
            this.ViewsTotalLabel.TabIndex = 10;
            this.ViewsTotalLabel.Text = "Views total";
            // 
            // KudosTodayValue
            // 
            this.KudosTodayValue.AutoSize = true;
            this.KudosTodayValue.Location = new System.Drawing.Point(13, 30);
            this.KudosTodayValue.Name = "KudosTodayValue";
            this.KudosTodayValue.Size = new System.Drawing.Size(13, 17);
            this.KudosTodayValue.TabIndex = 11;
            this.KudosTodayValue.Text = "-";
            // 
            // KudosTotalValue
            // 
            this.KudosTotalValue.AutoSize = true;
            this.KudosTotalValue.Location = new System.Drawing.Point(13, 67);
            this.KudosTotalValue.Name = "KudosTotalValue";
            this.KudosTotalValue.Size = new System.Drawing.Size(13, 17);
            this.KudosTotalValue.TabIndex = 12;
            this.KudosTotalValue.Text = "-";
            // 
            // ViewsTodayValue
            // 
            this.ViewsTodayValue.AutoSize = true;
            this.ViewsTodayValue.Location = new System.Drawing.Point(13, 104);
            this.ViewsTodayValue.Name = "ViewsTodayValue";
            this.ViewsTodayValue.Size = new System.Drawing.Size(13, 17);
            this.ViewsTodayValue.TabIndex = 13;
            this.ViewsTodayValue.Text = "-";
            // 
            // ViewsTotalValue
            // 
            this.ViewsTotalValue.AutoSize = true;
            this.ViewsTotalValue.Location = new System.Drawing.Point(13, 141);
            this.ViewsTotalValue.Name = "ViewsTotalValue";
            this.ViewsTotalValue.Size = new System.Drawing.Size(13, 17);
            this.ViewsTotalValue.TabIndex = 14;
            this.ViewsTotalValue.Text = "-";
            // 
            // DescriptionValue
            // 
            this.DescriptionValue.AutoSize = true;
            this.DescriptionValue.Location = new System.Drawing.Point(13, 67);
            this.DescriptionValue.Name = "DescriptionValue";
            this.DescriptionValue.Size = new System.Drawing.Size(13, 17);
            this.DescriptionValue.TabIndex = 15;
            this.DescriptionValue.Text = "-";
            // 
            // TitleValue
            // 
            this.TitleValue.AutoSize = true;
            this.TitleValue.Location = new System.Drawing.Point(13, 30);
            this.TitleValue.Name = "TitleValue";
            this.TitleValue.Size = new System.Drawing.Size(13, 17);
            this.TitleValue.TabIndex = 16;
            this.TitleValue.Text = "-";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.TitleLabel);
            this.flowLayoutPanel1.Controls.Add(this.TitleValue);
            this.flowLayoutPanel1.Controls.Add(this.DescriptionLabel);
            this.flowLayoutPanel1.Controls.Add(this.DescriptionValue);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(171, 116);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.KudosTodayLabel);
            this.flowLayoutPanel2.Controls.Add(this.KudosTodayValue);
            this.flowLayoutPanel2.Controls.Add(this.KudosTotalLabel);
            this.flowLayoutPanel2.Controls.Add(this.KudosTotalValue);
            this.flowLayoutPanel2.Controls.Add(this.ViewsTodayLabel);
            this.flowLayoutPanel2.Controls.Add(this.ViewsTodayValue);
            this.flowLayoutPanel2.Controls.Add(this.ViewsTotalLabel);
            this.flowLayoutPanel2.Controls.Add(this.ViewsTotalValue);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(171, 234);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(200, 170);
            this.flowLayoutPanel2.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.VoteUpButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form1";
            this.Text = "The Dumpert Up Voter!";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VoteUpButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label KudosTodayLabel;
        private System.Windows.Forms.Label ViewsTodayLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label KudosTotalLabel;
        private System.Windows.Forms.Label ViewsTotalLabel;
        private System.Windows.Forms.Label KudosTodayValue;
        private System.Windows.Forms.Label KudosTotalValue;
        private System.Windows.Forms.Label ViewsTodayValue;
        private System.Windows.Forms.Label ViewsTotalValue;
        private System.Windows.Forms.Label DescriptionValue;
        private System.Windows.Forms.Label TitleValue;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}

