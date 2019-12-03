﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
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

        public Form2()
        {
            InitializeComponent();

            //Utils.MouseUtils.MoveToScreenCoordinate(0,0);
            MouseHook = new MouseHook();
            MouseHook.SetHook();

            KeyboardHook = new GlobalKeyboardHook();
            KeyboardHook.KeyboardPressed += OnKeyPressed;
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
            if (Actions == null)
            { 
                MessageBox.Show("Dit ging mis, dit ging helemaal mis. Je moet wel wat muis klikjes invoeren voordat je dit kan uitvoeren natuurlijk.");
                return;
            }

            var dumpertUrl = DumpertUrlText.Text;

            if(string.IsNullOrWhiteSpace(dumpertUrl))
            {
                MessageBox.Show("Voer alsjeblieft een Dumpert URL in. Anders kan ik toch niet voor je voten! Mallerd.");
                return;
            }

            Clipboard.SetText(dumpertUrl);

            int count = 1;
            do
            {
                int totalActions = Actions.Count;
                for (int i = 0; i < totalActions; i++)
                {
                    var action = Actions[i];
                    
                    await Task.Delay(TimeSpan.FromMilliseconds(action.MilisecondsEllapsed));

                    //skip the last action, where we press the stop button
                    if(i == totalActions - 1)
                    { continue; }

                    MouseUtils.MoveToScreenCoordinate(action.X, action.Y);

                    if (action.ButtonClicked == MouseButtons.Left)
                        MouseUtils.LeftClick();
                    else if(action.ButtonClicked == MouseButtons.Right)
                        MouseUtils.RightClick();
                }
                CounterLabel.Text = "Votes: " + count;
            } while (count++ < 5000);
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
                Title = "Open muis klikjes"
            };

            if (openFileDialog.ShowDialog() != DialogResult.OK)
                return;

            // If the file name is not an empty string open it for saving.
            if (openFileDialog.FileName != "")
            {
                var json = System.IO.File.ReadAllText(openFileDialog.FileName);
                Actions = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ClickAction>>(json);
                ShowActions();
            }
        }
    }
}
