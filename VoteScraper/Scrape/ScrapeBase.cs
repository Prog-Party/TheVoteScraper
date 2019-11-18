using Knapcode.TorSharp;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace VoteScraper.Scrape
{
    public abstract class ScrapeBase
    {
        public CookieContainer Cookies { get; set; }

        protected TorSharpSettings Settings { get; set; }
        protected TorSharpProxy Proxy { get; set; }
        protected HttpClientHandler Handler { get; set; }

        public ScrapeBase()
        {
            Cookies = new CookieContainer();
        }

        public ScrapeBase(ScrapeBase scrapeBase)
        {
            Cookies = scrapeBase.Cookies;
            Settings = scrapeBase.Settings;
            Proxy = scrapeBase.Proxy;
            Handler = scrapeBase.Handler;
        }

        public virtual async Task Initialize()
        {
            // configure
            Settings = new TorSharpSettings
            {
                ZippedToolsDirectory = Path.Combine(Path.GetTempPath(), "TorZipped"),
                ExtractedToolsDirectory = Path.Combine(Path.GetTempPath(), "TorExtracted"),
                PrivoxyPort = 1337,
                TorSocksPort = 1338,
                TorControlPort = 1339,
                TorControlPassword = "foobar"
            };

            // download tools
            //await new TorSharpToolFetcher(Settings, new HttpClient()).FetchAsync();

            //Proxy = new TorSharpProxy(Settings);
            Handler = new HttpClientHandler
            {
                //Proxy = new WebProxy(new Uri("http://localhost:" + Settings.PrivoxyPort)),
                CookieContainer = Cookies
            };
        }
    }
}
