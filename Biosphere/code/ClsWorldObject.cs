using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biosphere;

namespace Biosphere.code
{
    class ClsWorldObject<T>
    {
        public int BaseCost { get; set; }
        public double CostMultiplier { get; set; }
        public int CurrentCost { get; set; }
        public int NumberBought { get; set; }
        public int NumberOwned { get; set; }
        public int BioMass { get; set; }
        public int Hunger { get; set; }
        public T ObjectType { get; set; }
        public double ChanceToEvolve { get; set; }
        public int IncomeIncrease { get; set; }

        public ClsWorldObject(int p_dblBaseCost, double p_dblCostMultiplier, int p_intBioMass, double p_dblEvolveChance, int p_intIncomeIncrease, T p_objType)
        {
            BaseCost = p_dblBaseCost;
            CostMultiplier = p_dblCostMultiplier;
            BioMass = p_intBioMass;
            NumberBought = 0;
            NumberOwned = 0;
            CurrentCost = BaseCost;
            ObjectType = p_objType;
            ChanceToEvolve = p_dblEvolveChance;
            IncomeIncrease = p_intIncomeIncrease;
            Hunger = BioMass / 10;
        }

        public bool CanReproduce(int p_intNumberOfFood)
        {
            return NumberOwned * BioMass / 10 < p_intNumberOfFood;            
        }
       
        public int BuyObject()
        {
            CalculateCost();
            NumberBought++;
            NumberOwned++;

            return IncomeIncrease;
        }

        public int IncrementObject(int p_intNumberToIncrement = 1)
        {
            NumberOwned += p_intNumberToIncrement;

            return IncomeIncrease * p_intNumberToIncrement;
        }

        private void CalculateCost()
        {
            int intCost = 0;

            for (int index = 0; index < NumberBought; index++)
            {
                intCost += (int)Math.Truncate(BaseCost * NumberBought * CostMultiplier);
            }

            CurrentCost = BaseCost + intCost;
        }

        public int ConsumeObject(int p_intAmount)
        {
            if (NumberOwned >= p_intAmount)
            {
                NumberOwned -= p_intAmount;

                if (NumberOwned < NumberBought)
                {
                    NumberBought = NumberOwned;
                }

                CalculateCost();
            }
            else
            {
                p_intAmount = 0;
            }

            return IncomeIncrease * p_intAmount * -1;
        }
    }
}
