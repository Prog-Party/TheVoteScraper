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

        private async void button1_Click(object sender, EventArgs e)
        {
            await Task.Delay(1000);
            Console.WriteLine("TEST");
            await Task.Delay(1000);
            Console.WriteLine("TEST2");
        }
    }
}
