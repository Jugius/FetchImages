using FetchImages.Common;
using System;
using System.Collections.Generic;

namespace FetchImages.Fetchers.Interfaces;
internal interface IFetcher
{
    public IEnumerable<Uri> FetchImages(ResponseResult response);
}
