using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace weather_stocks_ca
{
    public partial class stocks : Form
    {
        private string alphaVantageApiKey = "1OAK50NM34C9ERED";
        private List<SearchHistoryItem> searchHistoryList = new List<SearchHistoryItem>();

        public stocks()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {
        }

        private async void stocksFind_Click(object sender, EventArgs e)
        {
            string input = SearchBox.Text.Trim(); // Stock symbols input
            string[] symbols = input.Split(new char[] { ',', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries); //splits the symbols by comma, new line, and return, so user can request more than one stock at a time

            if (symbols.Length == 0)
            {
                MessageBox.Show("Please enter at least one stock symbol.");
                return;
            }


            foreach (string symbol in symbols)
            {
                var stockClient = new RestClient("https://www.alphavantage.co/query");
                var request = new RestRequest();

                request.AddParameter("function", "TIME_SERIES_INTRADAY");
                request.AddParameter("symbol", symbol);
                request.AddParameter("interval", "5min"); // 5 mins between each stock
                request.AddParameter("apikey", alphaVantageApiKey);

                // create a new search history item, loops through the symbols and adds them to the list
                var searchItem = new SearchHistoryItem { Symbol = symbol, SearchTime = DateTime.Now };

                searchHistoryList.Add(searchItem);
                listBoxSearchHistory.Items.Clear();
                foreach (var historyItem in searchHistoryList)
                {
                    listBoxSearchHistory.Items.Add($"{historyItem.Symbol} - {historyItem.SearchTime}");
                }

                try
                {
                    var response = await stockClient.ExecuteAsync(request);
                    Console.WriteLine(response.Content);

                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        var responseData = JsonConvert.DeserializeObject<AlphaVantageResponse>(response.Content);

                        if (responseData != null && responseData.TimeSeries != null)
                        {
                            bool foundData = false;

                            StockRichTextBox.AppendText($"Stock Symbol: {symbol}\n");

                            foreach (var timestamp in responseData.TimeSeries.Keys)
                            {
                                StockData stockData = responseData.TimeSeries[timestamp];
                                StockRichTextBox.AppendText($"Timestamp: {timestamp}, Stock Price: {stockData.Open}\n");
                                foundData = true;
                            }

                            if (!foundData)
                            {
                                StockRichTextBox.AppendText("Stock data not found in response.\n");
                            }
                        }
                        else
                        {
                            StockRichTextBox.AppendText($"No data available for symbol: {symbol}\n");
                        }
                    }
                    else
                    {
                        StockRichTextBox.AppendText($"Error fetching data for symbol {symbol}. Status code: {response.StatusCode}\n");
                    }
                }
                catch (Exception ex)
                {
                    StockRichTextBox.AppendText($"An error occurred for symbol {symbol}: {ex.Message}\n");
                }
            }

        }
        // user related buttons
        private void helpButton_Click(object sender, EventArgs e) // added to show users a sample of Symbols
        {
            MessageBox.Show("If you are experiecing API issues, please change your IP address, since this is a free API. The application is limited to 25 requests.\r\n\r\nAAPL(Apple Inc.)\r\nMSFT(Microsoft Corporation)\r\nGOOGL(Google)\r\nAMZN(Amazon.com)\r\nTSLA(Tesla)\r\nFB(Meta or Facebook)\r\nNFLX(Netflix)\r\nNVDA(NVIDIA)\r\nJPM(JPMorgan)\r\nV(Visa)");
        }

        private void clearHistoryButton_Click_1(object sender, EventArgs e)
        {
            searchHistoryList.Clear();
            listBoxSearchHistory.Items.Clear();
        }

        private void clearStocks_Click(object sender, EventArgs e)
        {
            StockRichTextBox.Clear();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
