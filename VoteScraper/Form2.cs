using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using VoteScraper.Model;
using VoteScraper.Utils;

namespace VoteScraper
{
    public partial class Form2 : Form
    {
        public List<ClickAction> Actions { get; set; }

        private bool ReadingIsStarted = false;
        private MouseHook MouseHook;
        private GlobalKeyboardHook KeyboardHook;
        private Stopwatch Stopwatch = new Stopwatch();

        private List<ClickAction> DumpertActions;
        private List<ClickAction> CheckIpActions;
        private List<ClickAction> TorReloadActions;

        private NordVpn.NordVpnController NordVpn { get; set; }

        Protocol.NordVpnVoteProtocol NordVpnProtocol;
        Protocol.TorVoteProtocol TorVoteProtocol;

        public Form2()
        {
            InitializeComponent();

            //DumpertUrlText.Text = "https://www.dumpert.nl/item/7803325_e71d8b7e";
            DumpertUrlText.Text = "https://www.dumpert.nl/item/7806741_23a93e75";

            //Utils.MouseUtils.MoveToScreenCoordinate(0,0);
            MouseHook = new MouseHook();
            MouseHook.SetHook();

            KeyboardHook = new GlobalKeyboardHook();
            KeyboardHook.KeyboardPressed += OnKeyPressed;


            NordVpn = VoteScraper.NordVpn.NordVpnController.Initialize();
            NordVpnNextServerText.Text = NordVpn.GetNext();

            NordVpnProtocol = new Protocol.NordVpnVoteProtocol(this);
            TorVoteProtocol = new Protocol.TorVoteProtocol(this);
        }

        public void SetStatus(string status)
        {
            CounterLabel.Text = status;
        }

        private void OnKeyPressed(object sender, GlobalKeyboardHookEventArgs e)
        {
            if(e.KeyboardData.Key == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyboardData.Key == Keys.Delete)
            {
                NordVpnProtocol.Stop();
                TorVoteProtocol.Stop();
            }
        }

        private void mh_MouseClickEvent(object sender, MouseEventArgs e, bool? isUp)
        {
            if (!isUp.HasValue || isUp.Value)
                return;

            if (e.Button != MouseButtons.Left && e.Button != MouseButtons.Right)
                return;

            var newAction = new ClickAction()
            {
                X = e.X,
                Y = e.Y,
                ButtonClicked = e.Button,
                MilisecondsEllapsed = Stopwatch.ElapsedMilliseconds
            };
            Actions.Add(newAction);
            Stopwatch.Reset();
            Stopwatch.Start();
            ShowActions();
        }

        private void ShowActions()
        {
            LoadedMouseClickiesTextbox.Text = string.Join("\r\n", Actions.Select(a => a.LogText));
        }

        private void ReadMouseClickies_Click(object sender, EventArgs e)
        {
            if(!ReadingIsStarted)
            {
                ReadMouseClickiesButton.Text = "Stop muis lees klikjes";
                Clipboard.SetText(DumpertUrlText.Text);
                Actions = new List<ClickAction>();
                MouseHook.MouseClickEvent += mh_MouseClickEvent;
                Stopwatch.Reset();
                Stopwatch.Start();
            } else
            {
                ReadMouseClickiesButton.Text = "Lees muis klikjes";
                Stopwatch.Stop();
                MouseHook.MouseClickEvent -= mh_MouseClickEvent;
                ShowActions();
            }

            ReadingIsStarted = !ReadingIsStarted;
        }

        private void SaveMouseClickiesButton_Click(object sender, EventArgs e)
        {
            if (Actions == null)
            {
                MessageBox.Show("Dit ging mis, dit ging helemaal mis. Je moet wel wat muis klikjes invoeren voordat je dit kan opslaan natuurlijk.");
                return;
            }

            var jsonToSave = Newtonsoft.Json.JsonConvert.SerializeObject(Actions);

            var saveFileDialog = new SaveFileDialog()
            {
                Filter = "Mouse Clickies json|*.json",
                Title = "Sla muis klikjes op"
            };
            saveFileDialog.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog.FileName != "")
            {
                System.IO.File.WriteAllText(saveFileDialog.FileName, jsonToSave);
            }
        }

        private void LoadMouseClickiesButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                Filter = "Mouse Clickies json|*.json",
                Title = "Open Dumpert klikjes"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            // If the file name is not an empty string open it for saving.
            if (openFileDialog.FileName != "")
            {
                DumpertActiesLabel.Text = System.IO.Path.GetFileName(openFileDialog.FileName);
                var json = System.IO.File.ReadAllText(openFileDialog.FileName);
                DumpertActions = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ClickAction>>(json);
            }
        }

        private void TorReloadButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                Filter = "Mouse Clickies json|*.json",
                Title = "Open Tor reload klikjes"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            // If the file name is not an empty string open it for saving.
            if (openFileDialog.FileName != "")
            {
                TorReloadLabel.Text = System.IO.Path.GetFileName(openFileDialog.FileName);
                var json = System.IO.File.ReadAllText(openFileDialog.FileName);
                TorReloadActions = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ClickAction>>(json);
            }
        }

        private void TorCheckIpButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                Filter = "Mouse Clickies json|*.json",
                Title = "Open Check IP klikjes"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            // If the file name is not an empty string open it for saving.
            if (openFileDialog.FileName != "")
            {
                TorCheckIpLabel.Text = System.IO.Path.GetFileName(openFileDialog.FileName);
                var json = System.IO.File.ReadAllText(openFileDialog.FileName);
                CheckIpActions = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ClickAction>>(json);
            }
        }

        private async void ExecuteNordVpnClickies_Click(object sender, EventArgs e)
        {
            NordVpnProtocol.DumpertActions = DumpertActions;
            NordVpnProtocol.RenewIpActions = CheckIpActions;
            NordVpnProtocol.DumpertUrl = DumpertUrlText.Text;

            if (!NordVpnProtocol.IsReady())
            {
                MessageBox.Show("Dit ging mis, dit ging helemaal mis. Je moet wel alle muis klikjes inladen voordat je dit kan uitvoeren natuurlijk.");
                return;
            }

            await NordVpnProtocol.Start();
        }

        private async void ExecuteMouseClickies_Click(object sender, EventArgs e)
        {
            TorVoteProtocol.DumpertActions = DumpertActions;
            TorVoteProtocol.DumpertUrl = DumpertUrlText.Text;

            if (!TorVoteProtocol.IsReady())
            {
                MessageBox.Show("Dit ging mis, dit ging helemaal mis. Je moet wel alle muis klikjes inladen voordat je dit kan uitvoeren natuurlijk.");
                return;
            }

            await TorVoteProtocol.Start();
        }

        private void DumpertUrlText_TextChanged(object sender, EventArgs e)
        {

        }

        private void DumpertUrlText_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(DumpertUrlText.Text);
        }

        private void NordVpnNextServerText_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(NordVpnNextServerText.Text);
            NordVpnNextServerText.Text = NordVpn.GetNext();
        }
    }
}
