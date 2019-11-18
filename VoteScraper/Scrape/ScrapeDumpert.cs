using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace VoteScraper.Scrape
{
    public class ScrapeDumpert : ScrapeBase
    {
        private HttpClient Client { get; set; }
        private HttpClient TorClient { get; set; }
        private string DumpertUrl { get; set; }

        private string DumpertId
            => DumpertUrl.Split('/').Last();

        private string DumpertId1
            => DumpertId.Split('_').First();

        private string DumpertId2
            => DumpertId.Split('_').Last();

        public override async Task Initialize()
        {
            await base.Initialize();

            Client = new HttpClient(Handler);
            Client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36 Edge/18.17763");
            Client.DefaultRequestHeaders.Accept.ParseAdd("text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
            Client.DefaultRequestHeaders.Connection.ParseAdd("keep-alive");

            TorClient = new HttpClient(TorHandler);
            Client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36 Edge/18.17763");
            Client.DefaultRequestHeaders.Accept.ParseAdd("text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");
            Client.DefaultRequestHeaders.Connection.ParseAdd("keep-alive");

            await Proxy.ConfigureAndStartAsync();
        }

        public async Task PlusKudo(string dumpertUrl)
        {
            DumpertUrl = dumpertUrl;
            await AcceptCookies(Client);

            await DoVotePositive(Client);
        }

        private async Task DoVotePositive(HttpClient client)
        {
            var viewUrl     = $"https://legacy.dumpert.nl/mobile_api/json/viewed/{DumpertId}/";
            var infoUrl     = $"https://api-live.dumpert.nl/mobile_api/json/info/{DumpertId}/";
            var relatedUrl  = $"https://api-live.dumpert.nl/mobile_api/json/related/{DumpertId}/";
            var commentsUrl = $"https://comments.dumpert.nl/embed/{DumpertId1}/{DumpertId2}/comments/?beta=1";
            var upUrl       = $"https://legacy.dumpert.nl/mobile_api/json/rating/{DumpertId}/up/";
            
            var baseCall = await client.GetAsync(DumpertUrl);
            baseCall.EnsureSuccessStatusCode();

            await Task.Delay(500);

            var viewCall = await client.GetAsync(viewUrl);
            viewCall.EnsureSuccessStatusCode();

            var infoCall = await client.GetAsync(infoUrl);
            infoCall.EnsureSuccessStatusCode();

            var relatedCall = await client.GetAsync(relatedUrl);
            relatedCall.EnsureSuccessStatusCode();

            await Task.Delay(2000 + new Random().Next(1000, 3000));

            var upCall = await client.GetAsync(upUrl);
            upCall.EnsureSuccessStatusCode();

            var result = await upCall.Content.ReadAsStringAsync();

        }

        private async Task AcceptCookies(HttpClient client)
        {
            var dumpert = await client.GetAsync("https://www.dumpert.nl/");
            var dumpertResult = await dumpert.Content.ReadAsStringAsync();
            
            await Task.Delay(3000);

            var date = DateTime.Now.AddDays(1825);

            Cookies.Add(new System.Net.Cookie("cpc", "10", "/", "dumpert.nl")
            {
                Expires = date
            });

            var epochMilliseconds = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1)).TotalMilliseconds;
            var r = (long)Math.Floor((1 + epochMilliseconds) * new Random().NextDouble());
            
            var acceptUrl = $"http://dumpert.nl/?kudtcookiewet=jakapmetzeuren&kudtcookiernd={r}";
            client.DefaultRequestHeaders.Referrer = new Uri("http://kudtkoekiewet.nl/?t=http://dumpert.nl/");


            var cookiePass = await client.GetAsync(acceptUrl);
            var cookiePassResult = await cookiePass.Content.ReadAsStringAsync();
        }

        public void StopScraping()
        {
            Proxy.Stop();
        }
    }
}
