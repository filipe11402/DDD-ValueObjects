using DemoDDDValueObjects.API.ValueObjects;

namespace DemoDDDValueObjects.API.Entities;

public class Car
{
    public string Id { get; private set; }

    public CarBrand Brand { get; private set; }

    public CarModel Model { get; private set; }

    public Car(string id, CarBrand brand, CarModel model)
    {
        Id = id;
        Brand = brand;
        Model = model;
    }
}
