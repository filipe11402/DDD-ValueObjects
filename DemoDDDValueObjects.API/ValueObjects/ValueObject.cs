namespace DemoDDDValueObjects.API.ValueObjects
{
    public abstract class ValueObject : IEquatable<ValueObject>
    {
        public ValueObject()
        {
        }

        public bool Equals(ValueObject? other)
        {
            if (other is null) { return false; }

            return ValuesAreTheSame(other);
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
            return other.GetEqualityComponents().SequenceEqual(other.GetEqualityComponents());
        }

        public override int GetHashCode()
        {
            return GetHashCode();
        }
    }
}
