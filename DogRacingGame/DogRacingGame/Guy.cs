using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRacingGame
{
    class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;
        public Label MyNameLabel;

        public void UpdateLabels()
        {
            // Set my label to my bet’s description, and the label on my
            // radio button to show my cash (“Joe has 43 bucks”)
            MyRadioButton.Text = string.Format("{0} has {1} bucks", Name, Cash);
            MyLabel.Text = MyBet.GetDescription();
            MyNameLabel.Text = Name;
        }

        public void ClearBet()
        {
            MyBet.Amount = 0;
            MyBet.Dog = 0;
        }

        public bool PlaceBet(int betAmount, int dog)
        {
            if (Cash >= betAmount)
            {
                MyBet.Amount = betAmount;
                MyBet.Bettor = this;
                MyBet.Dog = dog;
                return true;
            }
            return false;
        }

        public void Collect(int winner)
        {
            Cash = Cash + MyBet.PayOut(winner);
            // Clear the bet
            ClearBet();
        }

        public void UpdateLabels(object sender, EventArgs e)
        {
            UpdateLabels();
        }
    }
}
