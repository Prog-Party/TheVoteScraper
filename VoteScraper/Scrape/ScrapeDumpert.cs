using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace VoteScraper.Scrape
{
    public class ScrapeDumpert : ScrapeBase
    {
        public async Task Execute()
        {
            var httpClient = new HttpClient(Handler);
            await Proxy.ConfigureAndStartAsync();
            Console.WriteLine(await httpClient.GetStringAsync("http://api.ipify.org"));
            Proxy.Stop();
        }
    }
}
