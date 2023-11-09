namespace weather_stocks_ca
{
    partial class welcome
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
            panel1 = new Panel();
            label1 = new Label();
            openStocks = new Button();
            openNews = new Button();
            exitButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 37, 55);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(753, 100);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(39, 37, 55);
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(93, 44);
            label1.Name = "label1";
            label1.Size = new Size(95, 22);
            label1.TabIndex = 12;
            label1.Text = "Welcome";
            // 
            // openStocks
            // 
            openStocks.Location = new Point(274, 262);
            openStocks.Name = "openStocks";
            openStocks.Size = new Size(211, 55);
            openStocks.TabIndex = 13;
            openStocks.Text = "Launch Stocks";
            openStocks.UseVisualStyleBackColor = true;
            openStocks.Click += openStocks_Click;
            // 
            // openNews
            // 
            openNews.Location = new Point(274, 182);
            openNews.Name = "openNews";
            openNews.Size = new Size(211, 55);
            openNews.TabIndex = 14;
            openNews.Text = "Launch News";
            openNews.UseVisualStyleBackColor = true;
            openNews.Click += openNews_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(274, 343);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(211, 55);
            exitButton.TabIndex = 15;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 450);
            Controls.Add(exitButton);
            Controls.Add(openNews);
            Controls.Add(openStocks);
            Controls.Add(panel1);
            Name = "welcome";
            Text = "welcome";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button openStocks;
        private Button openNews;
        private Button exitButton;
    }
}