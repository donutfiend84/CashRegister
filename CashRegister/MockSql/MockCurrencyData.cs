namespace CashRegister.MockSql
{
    /// <summary>
    /// In a full application, we would expect certain configuration data to come from a DB,
    /// based on user permissions, biographical information, currency configuration, etc.
    /// 
    /// For the purposes of this test, we will simply mock the data in a form it might be 
    /// typically expected.
    /// </summary>
    class MockCurrencyData
    {
        public string CountryCode { get; set; }
        public string CountryDisplayText { get; set; }
        public string[] CurrencyTypes { get; set; }

        /// <summary>
        /// Constructor for easy mock data initialization
        /// </summary>
        /// <param name="countryCode">Two character country code</param>
        /// <param name="countryDisplayText">The user friendly display name for this country</param>
        /// <param name="currencyTypes">An array of strings representing various currencies available to this country</param>
        public MockCurrencyData(string countryCode, string countryDisplayText, string[] currencyTypes)
        {
            CountryCode = countryCode;
            CountryDisplayText = countryDisplayText;
            CurrencyTypes = currencyTypes;
        }

        /// <summary>
        /// Gets an array of mock currency data, to simulate what we right receive from an external data source
        /// </summary>
        /// <returns>Returns mock currency data for a few example countries</returns>
        public static MockCurrencyData[] GetMockCurrencyData()
        {
            return new MockCurrencyData[2]
            {
                new MockCurrencyData("US", "United States", new string[1]{ "Dollar" } ),
                new MockCurrencyData("UK", "United Kingdom", new string[2]{ "Euro", "Pound" })
            };
        }
    }
}
