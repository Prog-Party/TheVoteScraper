using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoteScraper.Model;
using VoteScraper.Utils;

namespace VoteScraper.Protocol
{
    public class TorVoteProtocol
    {
        public List<ClickAction> DumpertActions { get; set; }
        public List<ClickAction> TorCheckIpActions { get; set; }
        public List<ClickAction> TorReloadActions { get; set; }
        public string DumpertUrl { get; set; }
        private Form2 Form { get; set; }

        public TorVoteProtocol(Form2 form)
        {
            Form = form;
        }

        public bool IsReady()
            => DumpertActions?.Any() == true && 
                !string.IsNullOrWhiteSpace(DumpertUrl);

        public async Task Start()
        {
            Clipboard.SetText(DumpertUrl);

            int count = 1;
            do
            {
                int totalActions = DumpertActions.Count;
                for (int i = 0; i < totalActions; i++)
                {
                    var action = DumpertActions[i];

                    await Task.Delay(TimeSpan.FromMilliseconds(action.MilisecondsEllapsed));

                    //skip the last action, where we press the stop button
                    if (i == totalActions - 1)
                    { continue; }

                    MouseUtils.MoveToScreenCoordinate(action.X, action.Y);

                    if (action.ButtonClicked == MouseButtons.Left)
                        MouseUtils.LeftClick();
                    else if (action.ButtonClicked == MouseButtons.Right)
                        MouseUtils.RightClick();
                }
                Form.SetStatus("Votes: " + count);
            } while (count++ < 5000);
        }
    }
}
