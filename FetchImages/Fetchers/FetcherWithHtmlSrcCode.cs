using FetchImages.Common;
using System;
using System.Collections.Generic;

namespace FetchImages.Fetchers;
internal class FetcherWithHtmlSrcCode : Interfaces.IFetcher
{
    const string imageHtmlCode = "<img";
    const string imageSrcCode = @"src=""";
    public IEnumerable<Uri> FetchImages(ResponseResult response)
    {
        string responseUri = response.QueryUri.ToString();
        string content = response.RawContentString;

        if (!responseUri.StartsWith("http://") && !responseUri.StartsWith("https://"))
            responseUri = "https://" + responseUri;

        string baseUrl = GetBaseURL(responseUri);

        int index = content.IndexOf(imageHtmlCode);

        while (index != -1)
        {
            //Remove previous data
            content = content.Substring(index);

            //Find the location of the two quotes that mark the image's location
            int brackedEnd = content.IndexOf('>'); //make sure data will be inside img tag
            int start = content.IndexOf(imageSrcCode) + imageSrcCode.Length;
            int end = content.IndexOf('"', start + 1);

            //Extract the line
            if (end > start && start < brackedEnd)
            {
                string img = content.Substring(start, end - start);

                if (!img.StartsWith("http://")
                    && !img.StartsWith("https://")
                    && !string.IsNullOrEmpty(baseUrl))
                {
                    img = baseUrl + "/" + img.TrimStart('/');
                }

                if(Uri.TryCreate(img, UriKind.Absolute, out Uri result))
                    yield return result;
            }

            //Move index to next image location
            if (imageHtmlCode.Length < content.Length)
                index = content.IndexOf(imageHtmlCode, imageHtmlCode.Length);
            else
                index = -1;
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
