using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6_PartyPlanner
{
    public class Party
    {
        public const int COST_OF_FOOD_PER_PERSON = 25;
        public decimal CostOfDecorations = 0;
        private bool fancyDecorations;

        public Party(int numberOfPeople, bool fancyDecorations)
        {
            this.NumberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
        }

        private int numberOfPeople;
        public virtual int NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
            }
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            fancyDecorations = fancy;
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
        }

        public virtual decimal CalculateCost()
        {
            decimal totalCost = CostOfDecorations + (COST_OF_FOOD_PER_PERSON * NumberOfPeople);

            if (NumberOfPeople > 12)
            {

                return totalCost += 100M;
            }
            else
            {
                return totalCost;
            }
        }
    }
}
