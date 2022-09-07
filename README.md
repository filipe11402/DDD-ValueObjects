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
But, our product have a specific currency connected to that `Price`.

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

It looks alright, looking at a glance, but as mentioned above, our price is tied up to a currency.

So here is where a ValueObject can be used...
#### But why?
- Our currency if it's changed, we need to also update the price, to make it consistent with the price, as 5£ is not the same as 5€
- Our **domain experts see the Product price** as a conjunction of the `Price` and `Currency`


Let's refactor the above class in different approaches...

### Using classes
You can see this approach [here](DemoDDDValueObjects/)

What can we get from this?
- We can have an abstract class that will contain all the needed methods that will make a ValueObject, really a ValueObject.
- Our Price ValueObject, is immutable

What are the main disavantages?
- At the time(prior to dotnet 6), there wasn't, but now we have other data structures more suitable for this, which we will see next

### Using Records
You can see ValueObject being implemented with Records [here](DemoDDDValueObjectsWithRecords/)

Why is this better than classes?
- We have all the same behaviour, regarding `Structural Equality`, but we didn't need to create an abstract class, removing all that boilerplate code.
- If we are talking in bounded contexts, we can keep this ValueObject, in the same class of the Entity so make things more simple to read
- The Immutability is all implemented by default, from the framework

### Using Structs
You can see ValueObject being implemented with Structs [here](DemoDDDValueObjectsWithRecords/)

Advantages
- Same as the Records

Disavantages
- If we keep reference types as values of our ValueObjects, it can become expensive to our system because:
  - A thing called boxing and unboxing will be used to retrieve reference types values we have wrapped in the ValueObject
  - Reflexion to compare the values, whenever we use a reference type wrapped in the ValueObject


## References
[Vladimir Khorikov](https://enterprisecraftsmanship.com/posts/entity-vs-value-object-the-ultimate-list-of-differences/)

[Martin Fowler](https://martinfowler.com/bliki/ValueObject.html)

[Docs](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/implement-value-objects)