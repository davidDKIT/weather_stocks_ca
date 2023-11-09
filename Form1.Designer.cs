namespace weather_stocks_ca
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SubmitButton = new Button();
            SortingComboBox = new ComboBox();
            ArticleRichTextBox = new RichTextBox();
            exitButton = new Button();
            panel1 = new Panel();
            label1 = new Label();
            SearchBox = new TextBox();
            listBoxSearchHistory = new ListBox();
            clearHistoryButton = new Button();
            clearStocks = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(12, 106);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(163, 24);
            SubmitButton.TabIndex = 3;
            SubmitButton.Text = "Find News";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // SortingComboBox
            // 
            SortingComboBox.FormattingEnabled = true;
            SortingComboBox.Location = new Point(181, 106);
            SortingComboBox.Name = "SortingComboBox";
            SortingComboBox.Size = new Size(98, 23);
            SortingComboBox.TabIndex = 4;
            SortingComboBox.SelectedIndexChanged += SortingComboBox_SelectedIndexChanged;
            // 
            // ArticleRichTextBox
            // 
            ArticleRichTextBox.Location = new Point(12, 135);
            ArticleRichTextBox.Name = "ArticleRichTextBox";
            ArticleRichTextBox.Size = new Size(378, 303);
            ArticleRichTextBox.TabIndex = 8;
            ArticleRichTextBox.Text = "";
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(39, 37, 55);
            exitButton.BackgroundImageLayout = ImageLayout.Center;
            exitButton.FlatStyle = FlatStyle.Popup;
            exitButton.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.ForeColor = SystemColors.ButtonHighlight;
            exitButton.Location = new Point(623, 33);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(200, 48);
            exitButton.TabIndex = 14;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(39, 37, 55);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(exitButton);
            panel1.Controls.Add(SearchBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(834, 100);
            panel1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(39, 37, 55);
            label1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(3, 44);
            label1.Name = "label1";
            label1.Size = new Size(167, 22);
            label1.TabIndex = 12;
            label1.Text = "News Dashboard";
            // 
            // SearchBox
            // 
            SearchBox.Location = new Point(176, 43);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(178, 23);
            SearchBox.TabIndex = 14;
            // 
            // listBoxSearchHistory
            // 
            listBoxSearchHistory.FormattingEnabled = true;
            listBoxSearchHistory.ItemHeight = 15;
            listBoxSearchHistory.Location = new Point(396, 135);
            listBoxSearchHistory.Name = "listBoxSearchHistory";
            listBoxSearchHistory.Size = new Size(201, 304);
            listBoxSearchHistory.TabIndex = 15;
            // 
            // clearHistoryButton
            // 
            clearHistoryButton.BackColor = Color.FromArgb(39, 37, 55);
            clearHistoryButton.FlatStyle = FlatStyle.Flat;
            clearHistoryButton.ForeColor = Color.Snow;
            clearHistoryButton.Location = new Point(396, 105);
            clearHistoryButton.Name = "clearHistoryButton";
            clearHistoryButton.RightToLeft = RightToLeft.Yes;
            clearHistoryButton.Size = new Size(201, 23);
            clearHistoryButton.TabIndex = 16;
            clearHistoryButton.Text = "Clear Search History";
            clearHistoryButton.UseVisualStyleBackColor = false;
            clearHistoryButton.Click += clearHistoryButton_Click;
            // 
            // clearStocks
            // 
            clearStocks.Location = new Point(285, 105);
            clearStocks.Name = "clearStocks";
            clearStocks.Size = new Size(68, 23);
            clearStocks.TabIndex = 21;
            clearStocks.Text = "Clear Stocks";
            clearStocks.UseVisualStyleBackColor = true;
            clearStocks.Click += clearStocks_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(834, 450);
            Controls.Add(clearStocks);
            Controls.Add(clearHistoryButton);
            Controls.Add(listBoxSearchHistory);
            Controls.Add(panel1);
            Controls.Add(ArticleRichTextBox);
            Controls.Add(SortingComboBox);
            Controls.Add(SubmitButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button SubmitButton;
        private ComboBox SortingComboBox;
        private RichTextBox ArticleRichTextBox;
        private Button exitButton;
        private Panel panel1;
        private Label label1;
        private TextBox SearchBox;
        private ListBox listBoxSearchHistory;
        private Button clearHistoryButton;
        private Button clearStocks;
    }
}