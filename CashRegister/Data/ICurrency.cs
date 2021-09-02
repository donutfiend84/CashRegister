namespace CashRegister.Data
{
    /// <summary>
    /// Interface to leave specific currency implementation to the various localized types
    /// </summary>
    interface ICurrency
    {
        Denomination[] GetCurrencyDenominations();
    }
}
