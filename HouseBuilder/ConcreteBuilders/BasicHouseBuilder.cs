using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Helpers;
using Builder.HouseBuilder.Abstraction;
using Builder.Models;

namespace Builder.HouseBuilder.ConcreteBuilders
{
    public class BasicHouseBuilder : IHouseBuilder, IPrinter
    {
        private House _house;

        public BasicHouseBuilder()
        {
            _house = new House();

        }

        public void SetBasicInfo()
        {
            _house.Type = "Simple House";
            _house.HasSwimmingPool = false;
        }

        public void LayFoundations()
        {
            _house.Foundations = new House.Foundation
            {
                ConcreteAmount = 10,
                Material = "Concrete"
            };
        }

        public void BuildWalls()
        {
            _house.Walls = new House.Wall
            {
                Material = "Brick",
                TotalLength = 50
            };
        }

        public void FitWindows()
        {
            _house.Windows = new House.Window
            {
                Amount = 5
            };
        }

        public void BuildRoof()
        {
            _house.RoofCovering = new House.Roof
            {
                Area = 50
            };
        }

        public House GetResult()
        {
            return _house;
        }

        public void GetInfo()
        {
            PrintInfo();
        }

        public void BuildExtras()
        {
            Console.WriteLine($"House does not have any extras...");
        }

        public void Reset()
        {
            _house = new House();
        }

        public void PrintInfo()
        {
            Console.WriteLine($"House Type: {_house.Type}");
            Console.WriteLine($"Foundations Info: " +
                              $"\rMaterial: {_house.Foundations.Material}, " +
                              $"\rConcrete Amount: {_house.Foundations.ConcreteAmount} m3");
        }
    }
}
