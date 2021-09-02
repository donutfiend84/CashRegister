namespace CashRegister.Data
{
    class Currency_UK : ICurrency
    {
        private bool useNonEuroCurrency;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_useNonEuroCurrency">Use non Euro currency (Pound) in place of the Euro.</param>
        public Currency_UK(bool _useNonEuroCurrency = false)
        {
            useNonEuroCurrency = _useNonEuroCurrency;
        }

        /// <summary>
        /// UK Regionalized. Returns the local currency denominations in an ordered list, 
        /// from largest at index zero, to smallest at last index
        /// </summary>
        /// <returns>Returns the local currency denominations in an ordered list.</returns>
        public Denomination[] GetCurrencyDenominations()
        {
            Denomination[] denominations;

            // Populate the various types of denominations from highest to lowest
            // This information could be pulled from an XML file, a table, or any other 
            // source, but for the purpose of this test, we will populate it here. 
            if (!useNonEuroCurrency) 
            {
                denominations = new Denomination[15]
                {
                    new Denomination(500,           "Five Hundred", "Five Hundreds"),
                    new Denomination(200,           "Two Hundred",  "Two Hundreds"),
                    new Denomination(100,           "Hundred",      "Hundreds"),
                    new Denomination(50,            "Fifty",        "Fifties"),
                    new Denomination(20,            "Twenty",       "Twenties"),
                    new Denomination(10,            "Ten",          "Tens"),
                    new Denomination(5,             "Five",         "Fives"),
                    new Denomination(2,             "Two Euro",     "Two Euro"),
                    new Denomination(1,             "One Euro",     "One Euro"),
                    new Denomination((decimal)0.5,  "Fifty Cent",   "Fifty Cents"),
                    new Denomination((decimal)0.2,  "Twenty Cent",  "Twenty Cents"),
                    new Denomination((decimal)0.1,  "Ten Cent",     "Ten Cents"),
                    new Denomination((decimal)0.05, "Five Cent",    "Five Cents"),
                    new Denomination((decimal)0.02, "Two Cent",     "Two Cents"),
                    new Denomination((decimal)0.01, "One Cent",     "One Cents")
                };
            }
            else
            {
                denominations = new Denomination[12]
                {
                    new Denomination(50,            "Fifty",    "Fifties"),
                    new Denomination(20,            "Twenty",   "Twenties"),
                    new Denomination(10,            "Ten",      "Tens"),
                    new Denomination(5,             "Five",     "Fives"),
                    new Denomination(2,             "Two Pound",     "Two Pound"),
                    new Denomination(1,             "One Pound",     "One Pound"),
                    new Denomination((decimal)0.5,  "Fifty Pence",   "Fifty Pence"),
                    new Denomination((decimal)0.2,  "Twenty Pence",  "Twenty Pence"),
                    new Denomination((decimal)0.1,  "Ten Pence",     "Ten Pence"),
                    new Denomination((decimal)0.05, "Five Pence",    "Five Pence"),
                    new Denomination((decimal)0.02, "Two Pence",     "Two Pence"),
                    new Denomination((decimal)0.01, "One Pence",     "One Pence")
                };
            }
            return denominations;
        }
    }
}
