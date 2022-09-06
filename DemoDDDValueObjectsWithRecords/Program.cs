using DemoDDDValueObjectsWithRecords.Entities;

var price = new Price(20, "EUR");
var otherPrice = new Price(30, "USD");

var firstProduct = new Product(Guid.NewGuid(), "Toilet paper", price);

var secondProduct = new Product(Guid.NewGuid(), "Water bottle", price);

var thirdProduct = new Product(Guid.NewGuid(), "Bubble Gum", otherPrice);

//True
Console.WriteLine(firstProduct.HaveSamePrice(secondProduct));

Console.WriteLine("--------------------------");

//False
Console.WriteLine(thirdProduct.HaveSamePrice(firstProduct));
Console.WriteLine(thirdProduct.HaveSamePrice(secondProduct));

Console.WriteLine("--------------------------");
