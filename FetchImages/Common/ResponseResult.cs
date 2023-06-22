using System;

namespace FetchImages.Common;

internal class ResponseResult
{
    public string RawQueryString { get; set; }
    public string RawContentString { get; set; }
    public Uri QueryUri { get; set; }
}
