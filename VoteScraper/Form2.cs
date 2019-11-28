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
        private Stopwatch Stopwatch = new Stopwatch();

        public Form2()
        {
            InitializeComponent();

            //Utils.MouseUtils.MoveToScreenCoordinate(0,0);
            MouseHook = new MouseHook();
            MouseHook.SetHook();
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

        private void ExecuteMouseClickies_Click(object sender, EventArgs e)
        {
            if (Actions == null)
            { 
                MessageBox.Show("Dit ging mis, dit ging helemaal mis. Je moet wel wat muis klikjes invoeren voordat je dit kan uitvoeren natuurlijk.");
                return;
            }

            //todo: Nog implementeren
        }
    }
}
