namespace weather_stocks_ca
{
    partial class stocks
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
            exitButton = new Button();
            label1 = new Label();
            SearchBox = new TextBox();
            clearHistoryButton = new Button();
            listBoxSearchHistory = new ListBox();
            StockRichTextBox = new RichTextBox();
            stocksFind = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            helpButton = new Button();
            clearStocks = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 37, 55);
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SearchBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 100);
            panel1.TabIndex = 11;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(39, 37, 55);
            exitButton.BackgroundImageLayout = ImageLayout.Center;
            exitButton.FlatStyle = FlatStyle.Popup;
            exitButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.ForeColor = SystemColors.ButtonHighlight;
            exitButton.Location = new Point(587, 44);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(200, 48);
            exitButton.TabIndex = 11;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(39, 37, 55);
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(3, 44);
            label1.Name = "label1";
            label1.Size = new Size(175, 22);
            label1.TabIndex = 12;
            label1.Text = "Stocks Dashboard";
            label1.Click += label1_Click;
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(184, 44);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(178, 23);
            SearchBox.TabIndex = 14;
            // 
            // clearHistoryButton
            // 
            clearHistoryButton.BackColor = Color.FromArgb(39, 37, 55);
            clearHistoryButton.FlatStyle = FlatStyle.Flat;
            clearHistoryButton.ForeColor = Color.Snow;
            clearHistoryButton.Location = new Point(393, 106);
            clearHistoryButton.Name = "clearHistoryButton";
            clearHistoryButton.RightToLeft = RightToLeft.Yes;
            clearHistoryButton.Size = new Size(201, 23);
            clearHistoryButton.TabIndex = 1;
            clearHistoryButton.Text = "Clear Search History";
            clearHistoryButton.UseVisualStyleBackColor = false;
            clearHistoryButton.Click += clearHistoryButton_Click_1;
            // 
            // listBoxSearchHistory
            // 
            listBoxSearchHistory.FormattingEnabled = true;
            listBoxSearchHistory.ItemHeight = 15;
            listBoxSearchHistory.Location = new Point(393, 134);
            listBoxSearchHistory.Name = "listBoxSearchHistory";
            listBoxSearchHistory.Size = new Size(201, 304);
            listBoxSearchHistory.TabIndex = 0;
            // 
            // StockRichTextBox
            // 
            StockRichTextBox.Location = new Point(12, 135);
            StockRichTextBox.Name = "StockRichTextBox";
            StockRichTextBox.Size = new Size(375, 303);
            StockRichTextBox.TabIndex = 17;
            StockRichTextBox.Text = "";
            // 
            // stocksFind
            // 
            stocksFind.Location = new Point(12, 106);
            stocksFind.Name = "stocksFind";
            stocksFind.Size = new Size(75, 23);
            stocksFind.TabIndex = 18;
            stocksFind.Text = "Find";
            stocksFind.UseVisualStyleBackColor = true;
            stocksFind.Click += stocksFind_Click;
            // 
            // helpButton
            // 
            helpButton.Location = new Point(93, 106);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(75, 23);
            helpButton.TabIndex = 19;
            helpButton.Text = "Help";
            helpButton.UseVisualStyleBackColor = true;
            helpButton.Click += helpButton_Click;
            // 
            // clearStocks
            // 
            clearStocks.Location = new Point(174, 106);
            clearStocks.Name = "clearStocks";
            clearStocks.Size = new Size(68, 23);
            clearStocks.TabIndex = 20;
            clearStocks.Text = "Clear Stocks";
            clearStocks.UseVisualStyleBackColor = true;
            clearStocks.Click += clearStocks_Click;
            // 
            // stocks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(799, 450);
            Controls.Add(clearStocks);
            Controls.Add(clearHistoryButton);
            Controls.Add(helpButton);
            Controls.Add(listBoxSearchHistory);
            Controls.Add(stocksFind);
            Controls.Add(StockRichTextBox);
            Controls.Add(panel1);
            Name = "stocks";
            Text = "stocks";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button exitButton;
        private TextBox SearchBox;
        private RichTextBox StockRichTextBox;
        private Button stocksFind;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button helpButton;
        private ListBox listBoxSearchHistory;
        private Button clearHistoryButton;
        private Button clearStocks;
    }
}