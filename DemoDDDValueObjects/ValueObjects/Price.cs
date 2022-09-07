namespace DemoDDDValueObjects.ValueObjects
{
    public class Price : ValueObject
    {
        public double Amount { get; init; }

        public string Currency { get; init; }

        public Price(double amount, string currency)
        {
            Amount = amount;
            Currency = currency;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Amount;
            yield return Currency;
        }
    }
}
