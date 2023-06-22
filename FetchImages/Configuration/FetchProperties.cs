namespace FetchImages.Configuration;

public class FetchProperties
{
    public bool UseHtmlSrcCode { get; set; }
    public bool UseRegexp { get; set; }
    public bool UseCustomRegexpPattern { get; set;   }
    public string CustomRegexpPattern { get; set; }
    public bool UseEmbeddedStrategies { get; set; }
}
