using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinationsOfCoins
{
    class Combinations
    {
        public int ChangePossibilities(int amount, int[] denominations)
        {
            int[] waysOfMakingNCents = new int[amount + 1]; //We will start with a lack of denominations, having only one option - to collect the amount 0
            waysOfMakingNCents[0] = 1;

            foreach (int coin in denominations)
            {
                for (int higherAmount = coin; higherAmount <= amount; higherAmount++)
                {
                    int higherAmountRemainder = higherAmount - coin;
                    waysOfMakingNCents[higherAmount] += waysOfMakingNCents[higherAmountRemainder];
                }
            }
            return waysOfMakingNCents[amount]; //Quantity of ways to collect the amount using available denominations
        }
    }
}