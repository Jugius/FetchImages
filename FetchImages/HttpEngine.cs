using System.Net.Http;
using System.Net;
using System;
using FetchImages.Common;
using System.Threading.Tasks;

namespace FetchImages;
internal class HttpEngine
{
    private static HttpClient httpClient;
    private static readonly TimeSpan httpTimeout = new TimeSpan(0, 0, 30);
    private static HttpClient HttpClient
    {
        get
        {
            if (httpClient == null)
            {
                var httpClientHandler = new HttpClientHandler
                {
                    AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate
                };

                httpClient = new HttpClient(httpClientHandler)
                {
                    Timeout = httpTimeout
                };
            }
            return httpClient;
        }
    }

    public static async Task<OperationResult<ResponseResult>> LoadPageContent(string requestString)
    {
        if (string.IsNullOrWhiteSpace(requestString))
            return new Exception("Empty request string");

        string sUri = requestString;
        if (!sUri.StartsWith("http://") && !sUri.StartsWith("https://"))
            sUri = "https://" + sUri;

        if (!Uri.TryCreate(sUri, UriKind.Absolute, out Uri uri))
            return new Exception("Error uri: " + requestString);

        ResponseResult result;
        try
        {
            using (var responseMessage = await HttpClient.GetAsync(uri).ConfigureAwait(false))
            {
                if (!responseMessage.IsSuccessStatusCode)
                    return new Exception($"Status code: {responseMessage.StatusCode}, reason: {responseMessage.ReasonPhrase}");

                result = new ResponseResult
                {
                    RawQueryString = requestString,
                    QueryUri = responseMessage.RequestMessage.RequestUri,
                    RawContentString = await responseMessage.Content.ReadAsStringAsync()
                };                
            }

        }
        catch (Exception ex)
        {
            return ex.GetBaseException();
        }

        return result;
    }
}
