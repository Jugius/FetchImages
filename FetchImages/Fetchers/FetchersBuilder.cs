using FetchImages.Fetchers.Interfaces;
using System.Collections.Generic;

namespace FetchImages.Fetchers;
internal class FetchersBuilder
{
    public IEnumerable<IFetcher> BuildFetchers()
    {
        var p = Configuration.AppSettings.Instance.FetchProperties;

        if (p.UseHtmlSrcCode)
            yield return new FetcherWithHtmlSrcCode();

        if (p.UseRegexp)
        {
            if (p.UseCustomRegexpPattern && !string.IsNullOrEmpty(p.CustomRegexpPattern))
            {
                yield return new FetcherWithRegex(p.CustomRegexpPattern);
            }
            else
            {
                yield return new FetcherWithRegex(Properties.Resources.RegExpression);
            }            
        }
        
        if(p.UseEmbeddedStrategies)
            yield return new FetcherWithEmbeddedStrategies();
    }
}
