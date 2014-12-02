using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogRacingGame
{
    class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            if (Amount == 0)
            {
                return string.Format("{0} hasn't placed a bet", Bettor.Name);
            }
            return string.Format("{0} bets {1} bucks on dog #{2}", Bettor.Name, Amount, Dog); 
        }

        public int PayOut(int Winner)
        {
            if (Dog == Winner)
            {
                return Amount;
            }
            return -Amount;
        }
    }
}
