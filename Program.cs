#region Description

//Builder is a creational design pattern that lets you construct complex objects step by step.
//The pattern allows you to produce different types and representations of an object using the same construction code.

#endregion


using Builder.HouseBuilder;
using Builder.HouseBuilder.Abstraction;
using Builder.HouseBuilder.ConcreteBuilders;

IHouseBuilder houseBuilder = new BasicHouseBuilder();
Director director = new Director(houseBuilder);
director.BuildHouse();
houseBuilder.GetInfo();

IHouseBuilder houseWithSwimmingPoolBuilder = new HouseWithSwimmingPoolBuilder();
director.ChangeBuilder(houseWithSwimmingPoolBuilder);
director.BuildHouse();
houseWithSwimmingPoolBuilder.GetInfo();



