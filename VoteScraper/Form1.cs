using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VoteScraper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void VoteUpButton_Click(object sender, EventArgs e)
        {
            var random = new Random();
            var sleeptimeMin = 1; //10 seconds
            var sleeptimeMax = 3; //30 seconds
            var executionTime = 2;

            var dumpertUrl = "https://www.dumpert.nl/item/6855811_0c30d07e"; // mindy

            for (int i = 0; i < executionTime; i++)
            {
                Console.WriteLine("Plus Kudo's like it's hot");
                var scraper = new Scrape.ScrapeDumpert();
                await scraper.Initialize();
                await scraper.PlusKudo(dumpertUrl);
                scraper.StopScraping();

                if(i+1 < executionTime)
                { 
                    var sleepingTime = random.Next(sleeptimeMin * 1000, sleeptimeMax * 1000);
                    Console.WriteLine("Sleep like a few ms: " + sleepingTime);
                    await Task.Delay(sleepingTime);
                }
            }

            Console.WriteLine("Done plussing");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
