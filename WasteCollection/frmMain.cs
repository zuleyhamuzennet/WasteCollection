using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WasteCollection.Infrastructure;
using WasteCollection.Infrastructure.Concrete;
using WasteCollection.Infrastructure.Constants;
using WasteCollection.Infrastructure.Enums;

namespace WasteCollection
{
    public partial class frmMain : Form
    {
        #region Properties

        private List<Waste> Wastes { get; set; }
        private List<WasteBin> WasteBins { get; set; }

        private Waste SelectedWaste { get; set; }

        #endregion

        #region Fields

        private readonly Game _game = new Game();

        private readonly Random _randomImage = new Random();

        #endregion

        public frmMain()
        {
            InitializeComponent();
            SetWaste();
            SetWasteBin();
            _game.PassingTimeChanged += GamePassingTimeChanged;
            _game.IsExpiredChanged += GameIsExpiredChanged;
            _game.ScoreChanged += ScoreChanged;
        }

        private void SetWaste()
        {
            Wastes = new List<Waste>()
            {
                new Waste
                {
                    ImagePath = "camsise.jpg", Name = WasteNames.GlassBootle, Volume = 600,
                    WasteBinType = WasteBinType.GlassBox
                },
                new Waste
                {
                    ImagePath = "cambardak.jpg", Name = WasteNames.Glass, Volume = 250,
                    WasteBinType = WasteBinType.GlassBox
                },
                new Waste
                {
                    ImagePath = "gazete.jpg", Name = WasteNames.Newspaper, Volume = 250,
                    WasteBinType = WasteBinType.PaperBox
                },
                new Waste
                {
                    ImagePath = "dergi.jpg", Name = WasteNames.Magazine, Volume = 200,
                    WasteBinType = WasteBinType.PaperBox
                },
                new Waste
                {
                    ImagePath = "domates.jpg", Name = WasteNames.Tomatoes, Volume = 150,
                    WasteBinType = WasteBinType.OrganicWaste
                },
                new Waste
                {
                    ImagePath = "salatalik.jpg", Name = WasteNames.Cucumber, Volume = 120,
                    WasteBinType = WasteBinType.OrganicWaste
                },
                new Waste
                {
                    ImagePath = "kolakutusu.jpg", Name = WasteNames.ColaBox, Volume = 350,
                    WasteBinType = WasteBinType.MetalBox
                },
                new Waste
                {
                    ImagePath = "salcakutusu.jpg", Name = WasteNames.PasteBox, Volume = 550,
                    WasteBinType = WasteBinType.MetalBox
                }
            };
        }

        private void SetWasteBin()
        {
            WasteBins = new List<WasteBin>()
            {
                new WasteBin {Capacity = 700, UnloadingScore = 0, WasteBinType = WasteBinType.OrganicWaste},
                new WasteBin {Capacity = 1200, UnloadingScore = 1000, WasteBinType = WasteBinType.PaperBox},
                new WasteBin {Capacity = 2200, UnloadingScore = 600, WasteBinType = WasteBinType.GlassBox},
                new WasteBin {Capacity = 2300, UnloadingScore = 800, WasteBinType = WasteBinType.MetalBox},
            };
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (_game.IsExpired || _game.PassingTime.TotalSeconds > 0)
            {
                MessageBox.Show(Messages.GameContinues);
            }
            else
            {
                GameStart();
                _game.Start();
            }
        }

        private void GamePassingTimeChanged(object sender, EventArgs e)
        {
            label1.Text = _game.RemainingTime.TotalSeconds.ToString();
        }

        private void GameIsExpiredChanged(object sender, EventArgs e)
        {
            if (_game.IsExpired)
            {
                _game.Finish();
                GameFinish();
            }
            else
            {
                ChangePicture();
            }
        }

        private void GameFinish()
        {
            MessageBox.Show($@"{Messages.GameFinish} {Messages.YourScore}: {_game.Score}");
            label1.BackColor = Color.White;
            label1.ForeColor = Color.LightSeaGreen;
            txtTimeBackground.BackColor = Color.White;
            txtTimeBackground.ForeColor = Color.LightSeaGreen;
            txtScoreBackground.BackColor = Color.White;
            txtScoreBackground.ForeColor = Color.LightSeaGreen;
            textBox2.BackColor = Color.White;
            textBox2.ForeColor = Color.LightSeaGreen;

            btnEmptyGlass.Enabled = false;
            btnEmptyMetal.Enabled = false;
            btnEmptyPaper.Enabled = false;
            btnEmptyOrganicWaste.Enabled = false;

            btnGlassBox.Enabled = false;
            btnMetalBox.Enabled = false;
            btnPaperBox.Enabled = false;
            btnOrganicWaste.Enabled = false;

            pictureBox.ImageLocation = null;
        }

        private void GameStart()
        {
            label1.BackColor = Color.LightSeaGreen;
            label1.ForeColor = Color.White;
            txtTimeBackground.BackColor = Color.LightSeaGreen;
            txtTimeBackground.ForeColor = Color.White;
            txtScoreBackground.BackColor = Color.LightSeaGreen;
            txtScoreBackground.ForeColor = Color.White;
            textBox2.BackColor = Color.LightSeaGreen;
            textBox2.ForeColor = Color.White;

            btnEmptyGlass.Enabled = true;
            btnEmptyMetal.Enabled = true;
            btnEmptyPaper.Enabled = true;
            btnEmptyOrganicWaste.Enabled = true;

            btnGlassBox.Enabled = true;
            btnMetalBox.Enabled = true;
            btnPaperBox.Enabled = true;
            btnOrganicWaste.Enabled = true;

            pictureBox.ImageLocation = null;
            listBoxGlass.Items.Clear();
            listBoxMetal.Items.Clear();
            listBoxPaper.Items.Clear();
            listBoxOrganicWaste.Items.Clear();

            pgBarGlass.Value = 0;
            pgBarMetal.Value = 0;
            pgBarPaper.Value = 0;
            pgBarOrganicWaste.Value = 0;

            textBox2.Text = @"0";
            label1.Text = _game.GameTime.TotalSeconds.ToString();
        }

        private void ScoreChanged(object sender, EventArgs e)
        {
            if (_game.Score > 0)
            {
                textBox2.Text = _game.Score.ToString();
            }
        }

        private void ChangePicture()
        {
            if (!_game.IsExpired)
            {
                SelectedWaste = Wastes.GetRange(0, Wastes.Count)
                    .OrderBy(i => _randomImage.Next()).Take(1).First();
                var path = SelectedWaste.ImagePath;
                pictureBox.ImageLocation = path;
            }
            else
            {
                pictureBox.Image = null;
            }
        }

        private void btnOrganicWaste_Click(object sender, EventArgs e)
        {
            InsertWaste(WasteBinType.OrganicWaste, listBoxOrganicWaste, pgBarOrganicWaste);
        }

        private void btnPaperBox_Click(object sender, EventArgs e)
        {
            InsertWaste(WasteBinType.PaperBox, listBoxPaper, pgBarPaper);
        }

        private void btnGlassBox_Click(object sender, EventArgs e)
        {
            InsertWaste(WasteBinType.GlassBox, listBoxGlass, pgBarGlass);
        }

        private void btnMetalBox_Click(object sender, EventArgs e)
        {
            InsertWaste(WasteBinType.MetalBox, listBoxMetal, pgBarMetal);
        }

        private void btnEmptyOrganicWaste_Click(object sender, EventArgs e)
        {
            ClearWaste(WasteBinType.OrganicWaste, listBoxOrganicWaste, pgBarOrganicWaste);
        }

        private void btnEmptyGlass_Click(object sender, EventArgs e)
        {
            ClearWaste(WasteBinType.GlassBox, listBoxGlass, pgBarGlass);
        }

        private void btnEmptyPaper_Click(object sender, EventArgs e)
        {
            ClearWaste(WasteBinType.PaperBox, listBoxPaper, pgBarPaper);
        }

        private void btnEmptyMetal_Click(object sender, EventArgs e)
        {
            ClearWaste(WasteBinType.MetalBox, listBoxMetal, pgBarMetal);
        }


        private void InsertWaste(WasteBinType wasteBinType, Control listBoxControl, Control pgBarControl)
        {
            if (_game.IsExpired) return;
            if (SelectedWaste.WasteBinType != wasteBinType) return;
            var wastebin = WasteBins.First(x => x.WasteBinType == wasteBinType);
            if (wastebin.Insert(SelectedWaste))
            {
                var lBox = (ListBox) listBoxControl;
                lBox.Items.Add($"{SelectedWaste.Name} ({SelectedWaste.Volume})");
                var pgBar = (ProgressBar) pgBarControl;
                pgBar.Value = wastebin.FullRate;
                _game.AddScore(SelectedWaste.Volume);
                ChangePicture();
            }
            else
            {
                if (wastebin.FullVolume >= wastebin.ClearVolume)
                {
                    MessageBox.Show(Messages.PleaseClear);
                }
            }
        }

        private void ClearWaste(WasteBinType wasteBinType, Control listBoxControl, Control pgBarControl)
        {
            if (_game.IsExpired) return;
            var wastebin = WasteBins.First(x => x.WasteBinType == wasteBinType);
            if (wastebin.Clear())
            {
                var lBox = (ListBox) listBoxControl;
                lBox.Items.Clear();
                var pgBar = (ProgressBar) pgBarControl;
                pgBar.Value = wastebin.FullRate;
                _game.AddScore(wastebin.UnloadingScore);
                _game.AddTime(wastebin.UnloadingTime);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_game.PassingTime.TotalSeconds <= 0)
            {
                var messages = MessageBox.Show(Messages.Exit, this.Text, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (messages == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                var messages = MessageBox.Show(Messages.GameIsRunningExit, this.Text, MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);
                if (messages == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
    }
}