namespace CashRegister.Data
{
    class Currency_US : ICurrency
    {
        /// <summary>
        /// US Regionalized. Returns the local currency denominations in an ordered list, 
        /// from largest at index zero, to smallest at last index
        /// </summary>
        /// <returns>Returns the local currency denominations in an ordered list.</returns>
        public Denomination[] GetCurrencyDenominations()
        {
            Denomination[] denominations;

            // Populate the various types of denominations from highest to lowest
            // This information could be pulled from an XML file, a table, or any other 
            // source, but for the purpose of this test, we will populate it here. 
            denominations = new Denomination[10]
            {
                new Denomination(100,           "Hundred",  "Hundreds"),
                new Denomination(50,            "Fifty",    "Fifties"),
                new Denomination(20,            "Twenty",   "Twenties"),
                new Denomination(10,            "Ten",      "Tens"),
                new Denomination(5,             "Five",     "Fives"),
                new Denomination(1,             "Dollar",   "Dollars"),
                new Denomination((decimal)0.25, "Quarter",  "Quarters"),
                new Denomination((decimal)0.1,  "Dime",     "Dimes"),
                new Denomination((decimal)0.05, "Nickel",   "Nickels"),
                new Denomination((decimal)0.01, "Penny",    "Pennies")
            };

            return denominations;
        }
    }
}
