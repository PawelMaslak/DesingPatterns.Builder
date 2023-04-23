#region Description

//Builder is a creational design pattern that lets you construct complex objects step by step.
//The pattern allows you to produce different types and representations of an object using the same construction code.

#endregion


using System.Runtime.InteropServices;
using Builder.DefaultBuilder;
using Builder.HouseBuilder;
using Builder.HouseBuilder.Abstraction;
using Builder.HouseBuilder.ConcreteBuilders;
using Builder.HouseBuilderExtensionMethods;
using Builder.Models;
using static System.Console;

IHouseBuilder houseBuilder = new BasicHouseBuilder();
Director director = new Director(houseBuilder);
director.BuildHouse();
houseBuilder.GetInfo();

IHouseBuilder houseWithSwimmingPoolBuilder = new HouseWithSwimmingPoolBuilder();
director.ChangeBuilder(houseWithSwimmingPoolBuilder);
director.BuildHouse();
houseWithSwimmingPoolBuilder.GetInfo();

var extensionMethodsHouse = ExtensionMethodsHouseBuilder.BuildHouse()
    .LayFoundations(new House.Foundation {ConcreteAmount = 10, Material = "Concrete"})
    .BuildWalls(new House.Wall {Material = "Brick", TotalLength = 10});

DefaultHouseBuilder defaultHouseBuilder = new DefaultHouseBuilder();

var defaultBuilderHouse = defaultHouseBuilder
    .BuildFoundations(new House.Foundation { ConcreteAmount = 10, Material = "Concrete" })
    .BuildWalls(new House.Wall { Material = "Brick", TotalLength = 10 })
    .Build();

