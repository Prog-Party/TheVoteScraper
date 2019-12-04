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

        private DumpertVoteProtocol Protocol { get; set; }

        private bool ReadingIsStarted = false;
        private MouseHook MouseHook;
        private GlobalKeyboardHook KeyboardHook;
        private Stopwatch Stopwatch = new Stopwatch();

        public Form2()
        {
            InitializeComponent();

            //Utils.MouseUtils.MoveToScreenCoordinate(0,0);
            MouseHook = new MouseHook();
            MouseHook.SetHook();

            KeyboardHook = new GlobalKeyboardHook();
            KeyboardHook.KeyboardPressed += OnKeyPressed;

            Protocol = new DumpertVoteProtocol(this);
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

        private async void ExecuteMouseClickies_Click(object sender, EventArgs e)
        {
            Protocol.DumpertUrl = DumpertUrlText.Text;

            if (Protocol.IsReady())
            { 
                MessageBox.Show("Dit ging mis, dit ging helemaal mis. Je moet wel alle muis klikjes inladen voordat je dit kan uitvoeren natuurlijk.");
                return;
            }

            await Protocol.Start();
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
                Protocol.DumpertActions = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ClickAction>>(json);
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
                Protocol.TorReloadActions = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ClickAction>>(json);
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
                Protocol.TorCheckIpActions = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ClickAction>>(json);
            }
        }
    }
}
