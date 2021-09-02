namespace CashRegister.Data
{
    /// <summary>
    /// A simple data structure for general denomination value and display data
    /// </summary>
    class Denomination
    {
        public decimal value;           // e.g. 0.01
        public string singularName;     // e.g. "Penny"
        public string pluralName;       // e.g. "Pennies"

        public Denomination(decimal _value, string _singularName, string _pluralName)
        {
            value = _value;
            singularName = _singularName;
            pluralName = _pluralName;
        }
    }
}
