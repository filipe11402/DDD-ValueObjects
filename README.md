# DDD Value Object concept demonstration

## Introduction
Different approaches on how to create Value Objects regarding DDD aspect.
All code that we talk about is present 

## What is a value object?
ValueObjects allow you to represent simple primitive types such as `string` or `double` in your system, but in a more comprehensive way.
Imagine you work in a Finance system, i think it's way more clear to have for example

```cs
public class Currency{
    //Can be EUR, USD...
    public string Value { get; init; }

    public Currency(string value){
        Value = value;
    }
}
```

This allow us to achieve 2 things
- Separation regarding `Currency` validation, where we can perform the validation on the `Currency` object
- Represent the Currency in our system in a more clear way, instead of using a `string`

---

## ValueObject characteristics
We consider a ValueObject on these circumstances
- Has no identity(id's)
- Equality is different from an `Entity`, ValueObjects are equal if all their properties match, we call this `Structural Equality`
- They are immutable, meaning once they are created they cannot change, if we need to change, we create a new one

---

## Approaches

### Context
Let's imagine a product, and our product will have a `Price`.
But, our product have a specific currency connected to that `Price` and that same price cannot be less than 10 **currency agnostic** for example.

Initially, we could design our `Entity` like this

```cs
public class Product{
    public Guid id { get; init; }

    public string Name { get; private set; }

    public double Price { get; private set; }

    public string Currency { get; private set; }

    public Product(Guid id, string name, double price, string currency)
    {
        Id = id;
        Name = name;
        Price = price;
        Currency = currency;
    }
}
```

It looks alright, looking at a glance, but as mentioned above, our price is tied up to a currency, and has a minimum amount.

So here is where a ValueObject can be used...
#### But why?
- Our currency if it's changed, we need to also update the price, to make it consistent with the price, as 5£ is not the same as 5€
- Our **domain experts see the Product price** as a conjunction of the `Price` and `Currency`


Let's refactor the above class in different approaches...

### Using classes
//TODO: 

### Using Records
//TODO: 

```cs
public record Price(double Amount, string Currency);
```


### Using Structs
//TODO: 

```cs
public struct Price(double Amount, string Currency);
```