using System;
using System.Windows.Forms;

namespace VoteScraper.Model
{
    public class ClickAction
    {
        public long MilisecondsEllapsed { get; set; }
        public MouseButtons ButtonClicked { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        private string LogTextButton
            => ButtonClicked == MouseButtons.Left ? "Linker knop" : "Rechter knop";

        private int AmountSeconds
            => Convert.ToInt32(Math.Floor((double)MilisecondsEllapsed / 1000));

        private string LogTextTime
        {
            get
            { 
                var result = "";
                if (AmountSeconds > 0)
                    result += $"{AmountSeconds} seconde, ";
                result += $"{MilisecondsEllapsed % 1000} ms";
                return result;
            }
        }

        public string LogText
            => $"[x: {X}, y: {Y}] - {LogTextButton} - {LogTextTime}";
    }
}
