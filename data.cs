using Newtonsoft.Json;

public class NewsResponse
{
    public string status { get; set; }
    public int totalResults { get; set; }
    public List<Article> articles { get; set; }
}

public class Article
{
    public string author { get; set; } // Author of the article
    public string title { get; set; } // Title of the article
    public string description { get; set; } // Description or summary of the article
    public string url { get; set; } // URL of the article
    public string urlToImage { get; set; } // URL to an image associated with the article
    public DateTime publishedAt { get; set; } // Date and time when the article was published
    public string content { get; set; } // The content or body of the article
}

public class NewsArticle
{
    public NewsSource Source { get; set; }
    public string Author { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Url { get; set; }
    public string UrlToImage { get; set; }
    public string PublishedAt { get; set; }
    public string Content { get; set; }
}

public class NewsSource
{
    public string Id { get; set; }
    public string Name { get; set; }
}
public class AlphaVantageResponse
{
    [JsonProperty("Time Series (5min)")]
    public Dictionary<string, StockData> TimeSeries { get; set; }
}

public class StockData
{
    [JsonProperty("1. open")]
    public string Open { get; set; }

    [JsonProperty("2. high")]
    public string High { get; set; }

    [JsonProperty("3. low")]
    public string Low { get; set; }

    [JsonProperty("4. close")]
    public string Close { get; set; }

    [JsonProperty("5. volume")]
    public string Volume { get; set; }
}

public class TimeSeries
{
    public Dictionary<string, IntradayData> Data { get; set; }
}

public class IntradayData
{
    public string Open { get; set; }
    public string High { get; set; }
    public string Low { get; set; }
    public string Close { get; set; }
    public string Volume { get; set; }
}
// search history 
public class SearchHistoryItem
{
    public string Symbol { get; set; }
    public DateTime SearchTime { get; set; }
}
