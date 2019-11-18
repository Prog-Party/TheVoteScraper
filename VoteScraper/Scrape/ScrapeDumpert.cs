using System.Net.Http;
using System.Threading.Tasks;

namespace VoteScraper.Scrape
{
    public class ScrapeDumpert : ScrapeBase
    {
        private HttpClient Client { get; set; }
        private string DumpertUrl { get; set; }

        public override async Task Initialize()
        {
            await base.Initialize();

            Client = new HttpClient(Handler);
            Client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.140 Safari/537.36 Edge/18.17763");
            Client.DefaultRequestHeaders.Accept.ParseAdd("text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8");

            //await Proxy.ConfigureAndStartAsync();
        }

        public async Task PlusKudo(string dumpertUrl)
        {
            DumpertUrl = dumpertUrl;
            await NavigateToDumpert();
            //await Client.GetStringAsync("https://platform.simplytranslate.nl/Api/CallbackTest");
        }

        private async Task NavigateToDumpert()
        {
            var dumpert = await Client.GetAsync(DumpertUrl);

            var result = await dumpert.Content.ReadAsStringAsync();
        }

        public void StopScraping()
        {
            Proxy.Stop();
        }
    }
}
