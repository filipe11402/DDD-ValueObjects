namespace DemoDDDValueObjects.API.ValueObjects;

public class CarModel : ValueObject
{
    public string Value { get; init; }

    public CarModel(string value)
    {
        Value = value;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Value;
    }
}
