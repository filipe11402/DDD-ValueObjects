namespace DemoDDDValueObjectsWithRecords.Entities;

public class Product
{
    public Guid Id { get; init; }

    public string Name { get; private set; }

    public Price Price { get; private set; }

    public Product(Guid id, string name, Price price)
    {
        Id = id;
        Name = name;
        Price = price;
    }

    public bool HaveSamePrice(Product other)
        => Price.Equals(other.Price);
}

//public record Price(double Amount, string Currency);

//TODO: showcase with Create static method

public record struct Price(double Amount, string Currency);