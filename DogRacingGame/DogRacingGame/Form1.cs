using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRacingGame
{
    public partial class Form1 : Form
    {
        private readonly Guy[] _guys = new Guy[3];
        private readonly Greyhound[] _greyhounds = new Greyhound[4];
        private readonly Random _myRandom = new Random();

        public Form1()
        {
            InitializeComponent();
            CreateGuys();
            CreateDogs();
        }

        private void CreateDogs()
        {
            _greyhounds[0] = new Greyhound {Name = "Dog 1", MyPictureBox = dog1, StartingPosition = dog1.Left, RacetrackLength = racetrackPicBox.Width - dog1.Width, Randomizer = _myRandom };
            _greyhounds[1] = new Greyhound { Name = "Dog 2", MyPictureBox = dog2, StartingPosition = dog2.Left, RacetrackLength = racetrackPicBox.Width - dog2.Width, Randomizer = _myRandom };
            _greyhounds[2] = new Greyhound { Name = "Dog 3", MyPictureBox = dog3, StartingPosition = dog3.Left, RacetrackLength = racetrackPicBox.Width - dog3.Width, Randomizer = _myRandom };
            _greyhounds[3] = new Greyhound { Name = "Dog 4", MyPictureBox = dog4, StartingPosition = dog4.Left, RacetrackLength = racetrackPicBox.Width - dog4.Width, Randomizer = _myRandom };
        }

        private void CreateGuys()
        {
            _guys[0] = new Guy { Name = "Joe", Cash = 50, MyLabel = this.joeLabelBet, MyRadioButton = this.joeRadioButton, MyNameLabel = bettorNameLabel, MyBet = new Bet() };
            _guys[1] = new Guy {Name = "Bob", Cash = 75, MyLabel = this.bobLabelBet, MyRadioButton = this.bobRadioButton, MyNameLabel = bettorNameLabel, MyBet = new Bet() };
            _guys[2] = new Guy { Name = "Al", Cash = 45, MyLabel = this.alLabelBet, MyRadioButton = this.alRadioButton, MyNameLabel = bettorNameLabel, MyBet = new Bet() };

            foreach (var guy in _guys)
            {
                guy.MyBet.Bettor = guy;
                guy.MyRadioButton.CheckedChanged += guy.UpdateLabels;
            }
        }

        private void raceTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < _greyhounds.Length; i++)
            {
                if (_greyhounds[i].Run())
                {
                    raceTimer.Stop();
                    foreach (var guy in _guys)
                    {
                        guy.Collect(i + 1);
                    }
                    var result = MessageBox.Show(string.Format("{0} won the race", _greyhounds[i].Name), @"Winner", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        ResetRace();
                    }
                }
            }
        }

        private void ResetRace()
        {
            foreach (var greyhound in _greyhounds.Where(greyhound => greyhound != null))
            {
                greyhound.TakeStartingPosition();
            }
            racetrackPicBox.Enabled = true;
        }

        private void betButton_Click(object sender, EventArgs e)
        {
            racetrackPicBox.Enabled = false;
            raceTimer.Start();
        }

        private void betButton_Click_1(object sender, EventArgs e)
        {
            foreach (var guy in _guys)
            {
                if (bettorNameLabel.Text == guy.Name)
                {
                    var dog = Convert.ToInt32(numOfDog.Value);
                    var amount = Convert.ToInt32(numBetAmount.Value);

                    if (guy.PlaceBet(amount, dog))
                    {
                        guy.MyLabel.Text = guy.MyBet.GetDescription();
                    }
                    else
                    {
                        MessageBox.Show(string.Format("{0} can not cover the bet", guy.Name));
                    }
                    //guy.UpdateLabels();
                }
            }
        }
    }
}
