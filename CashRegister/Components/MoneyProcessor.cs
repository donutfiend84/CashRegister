using System;
using System.Collections.Generic;
using CashRegister.Data;

namespace CashRegister.Components
{
    class MoneyProcessor
    {
        private ICurrency _currency;
        private Random _rand;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="regionSpecificCurrency">Inject the specific region's currency.</param>
        public MoneyProcessor(ICurrency regionSpecificCurrency)
        {
            _currency = regionSpecificCurrency;

            // Initialize the randomizer here, since repeated rapid initializations in a loop can cause multiple 
            // iterations to repeat the same sequence.
            _rand = new Random();
        }

        /// <summary>
        /// Takes a single transaction, and returns the change from the currently configured currency
        /// </summary>
        /// <param name="amountOwed">The amount owed for this transaction</param>
        /// <param name="amountPaid">The amount paid for this transaction</param>
        /// <returns>A comma delimited string consisting of the change, sorted by quantity of each denomination</returns>
        public string GetChange(decimal amountOwed, decimal amountPaid)
        {
            decimal changeToReturn = amountPaid - amountOwed;

            if (changeToReturn < 0) return "Cannot make change from a negative number.";
            if (changeToReturn == 0) return "No change to return.";

            // As we iterate through the change, keep track of our tally here. 
            List<string> denominationReturns = new List<string>();

            Denomination[] denominations = _currency.GetCurrencyDenominations();

            // We randomize change when the amount owed is divisible by 3. Since we are working with decimals,
            // we need to raise them to whole numbers. 
            int decimalCount = BitConverter.GetBytes(decimal.GetBits(amountOwed)[3])[2];
            bool randomize = (amountOwed * (decimal)Math.Pow(10, decimalCount) ) % 3 == 0;

            // Starting with the largest denomination, check progressively smaller and smaller
            // denominations, until the exact value of the change is found
            for (int i = 0; i < denominations.Length; i++)
            {
                var denomination = denominations[i];
                if(changeToReturn >= denomination.value)
                {
                    int denominationQuantity;

                    // Count the max of this denomination within the remaining change
                    int maxDenominationQuantity = (int)Math.Floor(changeToReturn / denomination.value);

                    // Even when randomizing, the final index needs to return enough of the smallest currency 
                    // so the final change is still mathematically correct.
                    if (randomize && i != denominations.Length-1)
                    {
                        // Get a random amount of this currency that is still within the range of change 
                        // we need to return. We increase by 1, because zero is included in the random range,
                        // and the max integer less than the passed in value.
                        denominationQuantity = _rand.Next(maxDenominationQuantity + 1);

                        // If the random quantity is zero, don't insert anything into the returned change array
                        if (denominationQuantity == 0) continue;
                    }
                    else
                    {
                        // Use the max possible of this denomination
                        denominationQuantity = maxDenominationQuantity;
                    }

                    // Add this denomination to the string, appropriately singular or plural
                    denominationReturns.Add(
                        denominationQuantity + 
                        " " + 
                        ((denominationQuantity>1) ? denomination.pluralName : denomination.singularName)
                    );

                    // subtract the appropriate amount from the change
                    changeToReturn -= denominationQuantity * denomination.value;
                }
            }

            // If we did not end up at exactly zero, it means the provided denominations were insufficient 
            // to return exact change (for example in Canada, where the lowest denomination is 5 cents)
            if (changeToReturn != 0)
                denominationReturns.Add("Exact change could not be provided by the available denominations. " + changeToReturn + " is remaining.");

            return string.Join(",", denominationReturns);
        }
    }
}
