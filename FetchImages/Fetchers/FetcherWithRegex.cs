using FetchImages.Common;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FetchImages.Fetchers;
internal class FetcherWithRegex : Interfaces.IFetcher
{
    private readonly Regex regexImages;
    public FetcherWithRegex(string regexPattern)
    { 
        regexImages = new Regex(regexPattern);
    }
    public IEnumerable<Uri> FetchImages(ResponseResult response)
    {
        string responseUri = response.QueryUri.ToString();
        string content = response.RawContentString;

        if (!responseUri.StartsWith("http://") && !responseUri.StartsWith("https://"))
            responseUri = "https://" + responseUri;

        string baseUrl = GetBaseURL(responseUri);

        MatchCollection matchedAuthors = regexImages.Matches(content);
        for (int count = 0; count < matchedAuthors.Count; count++)
        {
            string img = matchedAuthors[count].Value;

            if (!img.StartsWith("http://")
                && !img.StartsWith("https://")
                && !string.IsNullOrEmpty(baseUrl))
            {
                img = baseUrl + "/" + img.TrimStart('/');
            }

            if (Uri.TryCreate(img, UriKind.Absolute, out Uri result))
                yield return result;
        }          
    }
    private static string GetBaseURL(string Url)
    {
        int inx = Url.IndexOf("://") + "://".Length;
        int end = Url.IndexOf('/', inx);

        if (end != -1)
            return Url.Substring(0, end);
        else
            return string.Empty;
    }
}
