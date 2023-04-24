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

#region Complex Objects Builder

//This type of builder creates default complex objects and loads them with predefined data

//Builder's instance implementing shared interface:
IHouseBuilder houseBuilder = new BasicHouseBuilder();
//Director class responsible for building an object.
//Director has method building the object but each object type can be different depending on builder class.
Director director = new Director(houseBuilder);
//Build an object
director.BuildHouse();
houseBuilder.GetInfo();
//Get created object:
var createdInstance = director.GetBuiltObject();
//We can pass multiple instances to the director to change the returned object:
IHouseBuilder houseWithSwimmingPoolBuilder = new HouseWithSwimmingPoolBuilder();
director.ChangeBuilder(houseWithSwimmingPoolBuilder);
director.BuildHouse();
houseWithSwimmingPoolBuilder.GetInfo();

#endregion

#region Builder With Extension Methods

//In this type of builder user is able to define all properties themselves.
//This also creates additional workload for User as he needs to define all necessary components of an object.

var extensionMethodsHouse = ExtensionMethodsHouseBuilder.BuildHouse()
    .LayFoundations(new House.Foundation { ConcreteAmount = 10, Material = "Concrete" })
    .BuildWalls(new House.Wall { Material = "Brick", TotalLength = 10 });

#endregion


#region Default Builder

DefaultHouseBuilder defaultHouseBuilder = new DefaultHouseBuilder();

var defaultBuilderHouse = defaultHouseBuilder
    .BuildFoundations(new House.Foundation { ConcreteAmount = 10, Material = "Concrete" })
    .BuildWalls(new House.Wall { Material = "Brick", TotalLength = 10 })
    .Build();

#endregion









