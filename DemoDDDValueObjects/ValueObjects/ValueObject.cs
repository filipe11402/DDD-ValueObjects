namespace DemoDDDValueObjects.ValueObjects;

public abstract class ValueObject : IEquatable<ValueObject>
{
    public ValueObject()
    {
    }

    public bool Equals(ValueObject? other)
    {
        return ValuesAreTheSame(other!);
    }

    public override bool Equals(object? obj)
    {
        if (obj is null) { return false; }

        if (obj is not ValueObject valueObject) { return false; }

        return ValuesAreTheSame(valueObject);
    }

    public static bool operator ==(ValueObject current, ValueObject other)
    {
        return current.Equals(other);
    }

    public static bool operator !=(ValueObject current, ValueObject other)
    {
        return !(current == other);
    }

    protected abstract IEnumerable<object> GetEqualityComponents();

    private bool ValuesAreTheSame(ValueObject other)
    {
        return GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
    }

    public override int GetHashCode()
    {
        return GetHashCode();
    }
}
