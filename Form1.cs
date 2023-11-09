using RestSharp;
using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace weather_stocks_ca
{
    public partial class Form1 : Form
    {
        private string newsApiKey = "3c0bc832ddff435d9d549c4ebc79d248";
        private List<Article> currentArticles;
        private List<SearchHistoryItem> searchHistoryList = new List<SearchHistoryItem>();
        private SortingOption currentSortingOption = SortingOption.Relevance;

        public enum SortingOption
        {
            Relevance,
            Popularity
        }

        public Form1()
        {
            InitializeComponent();
            this.Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Adding to sorting box upon load
            SortingComboBox.Items.Add(SortingOption.Relevance);
            SortingComboBox.Items.Add(SortingOption.Popularity);
            SortingComboBox.SelectedIndex = 0;
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string query = SearchBox.Text.Trim();
            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show("Please enter a search query.");
                return;
            }

            var newsClient = new RestClient("https://newsapi.org/v2/everything");
            var request = new RestRequest();
            string pageSize = "15";

            request.AddParameter("apiKey", newsApiKey);
            request.AddParameter("q", query);
            request.AddParameter("pageSize", pageSize);
            request.AddParameter("sortBy", currentSortingOption.ToString().ToLower());

            var searchItem = new SearchHistoryItem { Symbol = query, SearchTime = DateTime.Now };

            searchHistoryList.Add(searchItem);
            listBoxSearchHistory.Items.Clear();
            foreach (var historyItem in searchHistoryList)
            {
                listBoxSearchHistory.Items.Add($"{historyItem.Symbol} - {historyItem.SearchTime}");
            }
            try
            {
                var response = newsClient.Get(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    NewsResponse newsResponse = JsonConvert.DeserializeObject<NewsResponse>(response.Content);
                    currentArticles = newsResponse.articles;

                    ArticleRichTextBox.Clear();

                    foreach (var article in currentArticles)
                    {
                        ArticleRichTextBox.SelectionFont = new Font(ArticleRichTextBox.Font, FontStyle.Bold);
                        ArticleRichTextBox.AppendText(article.title + "\n");

                        ArticleRichTextBox.SelectionFont = new Font(ArticleRichTextBox.Font, FontStyle.Regular);
                        ArticleRichTextBox.AppendText("Author: " + article.author + "\n");
                        ArticleRichTextBox.AppendText("Description: " + article.description + "\n");
                        ArticleRichTextBox.AppendText("Published: " + article.publishedAt.ToString() + "\n");
                        ArticleRichTextBox.AppendText("URL: " + article.url + "\n");
                        ArticleRichTextBox.AppendText("---------------------------------------------------\n");
                    }
                }
                else
                {
                    MessageBox.Show("Error fetching news. Please check your API key and request parameters.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void SortingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSortingOption = (SortingOption)SortingComboBox.SelectedItem;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }


        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearHistoryButton_Click(object sender, EventArgs e)
        {
            searchHistoryList.Clear();
            listBoxSearchHistory.Items.Clear();
        }

        private void clearStocks_Click(object sender, EventArgs e)
        {
            ArticleRichTextBox.Clear();
        }
    }
}
