using DemoDDDValueObjectsWithRecords.ValueObjects;

var firstCarBrand = new CarBrand("Ferrari");
var matchingFirstCarBrand = new CarBrand("Ferrari");

var secondCarBrand = new CarBrand("Porsche");
var matchingSecondCarBrand = new CarBrand("Porsche");

//True
Console.WriteLine(firstCarBrand == matchingFirstCarBrand);
Console.WriteLine(secondCarBrand == matchingSecondCarBrand);

Console.WriteLine("--------------------------");

//False
Console.WriteLine(firstCarBrand == secondCarBrand);
Console.WriteLine(matchingFirstCarBrand == matchingSecondCarBrand);

Console.WriteLine("--------------------------");

//True
Console.WriteLine(firstCarBrand.Equals(matchingFirstCarBrand));
Console.WriteLine(secondCarBrand.Equals(matchingSecondCarBrand));

Console.WriteLine("--------------------------");

//False
Console.WriteLine(firstCarBrand.Equals(matchingSecondCarBrand));
Console.WriteLine(secondCarBrand.Equals(matchingFirstCarBrand));