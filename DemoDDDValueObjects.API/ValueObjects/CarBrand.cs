namespace DemoDDDValueObjects.API.ValueObjects;

public class CarBrand : ValueObject
{
    public string Value { get; init; }

    public CarBrand(string value)
    {
        Value = value;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}