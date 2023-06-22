using System;
using System.Collections.Generic;

namespace FetchImages.Common;
internal class FetchImagesResult
{
    public string RawQueryString { get; set; }
    public string ErrorMessage { get; set; }
    public List<Uri> Images { get; set; }
    public bool IsSuccess { get; set; }

}
