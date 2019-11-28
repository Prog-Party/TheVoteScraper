using Knapcode.TorSharp;
using System;
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
        protected HttpClientHandler TorHandler { get; set; }

        public ScrapeBase()
        {
            Cookies = new CookieContainer();
        }

        public ScrapeBase(ScrapeBase scrapeBase)
        {
            Cookies    = scrapeBase.Cookies;
            Settings   = scrapeBase.Settings;
            Proxy      = scrapeBase.Proxy;
            Handler    = scrapeBase.Handler;
            TorHandler = scrapeBase.TorHandler;
        }

        public virtual Task Initialize()
        {
            Handler = new HttpClientHandler
            {
                //Proxy = new WebProxy(new Uri("http://145.239.85.58:9300")),
                //Proxy = new WebProxy(new Uri("http://46.4.96.137:1080")),
                //Proxy = new WebProxy(new Uri("http://178.62.193.19:1080")),
                //Proxy = new WebProxy(new Uri("http://83.77.118.53:17171")),
                //UseProxy = true,
                CookieContainer = Cookies
            };

            return InitializeTor();
        }

        private async Task InitializeTor()
        {
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
            await new TorSharpToolFetcher(Settings, new HttpClient()).FetchAsync();

            // execute
            Proxy = new TorSharpProxy(Settings);
            TorHandler = new HttpClientHandler
            {
                Proxy = new WebProxy(new Uri("http://localhost:" + Settings.PrivoxyPort))
            };
        }
    }
}
