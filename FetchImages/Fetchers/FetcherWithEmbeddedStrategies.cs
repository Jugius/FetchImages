using FetchImages.Common;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace FetchImages.Fetchers;
internal class FetcherWithEmbeddedStrategies : Interfaces.IFetcher
{
    private static readonly Regex PrimeHomeRegex = new Regex(@"<img\s+src='(.*?)'\s+onclick=");
    private static readonly Regex OuthubOnlineRegex = new Regex(@"boardData:\s+'(.*?)',");
    public IEnumerable<Uri> FetchImages(ResponseResult response)
    {
        string responseUri = response.QueryUri.ToString();
        string content = response.RawContentString;

        if (!responseUri.StartsWith("http://") && !responseUri.StartsWith("https://"))
            responseUri = "https://" + responseUri;

        var resultUri = GetResult(content, responseUri);
        if(resultUri != null)
            yield return resultUri;
    }
    private static Uri GetResult(string content, string responseUri)
    {
        const string prime_home = "home.prime-group.com.ua/BoardsForPublic/BoardDetails";
        const string outhub_online = "outhub.online/BoardInfo/Details";

        if (IsStringContains(responseUri, prime_home, StringComparison.OrdinalIgnoreCase))
            return GetPrimeHomeResult(content);
        else if (IsStringContains(responseUri, outhub_online, StringComparison.OrdinalIgnoreCase))
            return GetOuthubOnlineResult(content);

        return null;
    }

    private static Uri GetOuthubOnlineResult(string content)
    {
        const string baseUri = "https://osc.gigacloud.ua:8080/v1/AUTH_7eefa60f4f3843faa7b6c70ba128f440/boards";
        Match match = OuthubOnlineRegex.Match(content);
        if (match.Success)
        {
            string boardBody = match.Groups[1].Value;
            var splitted = boardBody.Split(';');
            string year = splitted[3];
            string code = splitted[1];
            string uri = $"{baseUri}/{year}/{code}.jpg";
            return new Uri(uri);
        }
        else
        {
            return null;
        }
    }

    private static Uri GetPrimeHomeResult(string content)
    {
        Match match = PrimeHomeRegex.Match(content);
        if (match.Success)
        {
            return new Uri(match.Groups[1].Value);
        }
        else
        {
            return null;
        }
    }
    private static bool IsStringContains(string str, string substring,
                               StringComparison comp)
    {
        if (substring == null)
            throw new ArgumentNullException("substring",
                                         "substring cannot be null.");
        else if (!Enum.IsDefined(typeof(StringComparison), comp))
            throw new ArgumentException("comp is not a member of StringComparison",
                                     "comp");

        return str.IndexOf(substring, comp) >= 0;
    }
}
