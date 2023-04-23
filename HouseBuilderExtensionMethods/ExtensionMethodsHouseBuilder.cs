using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;

namespace Builder.HouseBuilderExtensionMethods
{
    public static class ExtensionMethodsHouseBuilder
    {
        public static House BuildHouse()
        {
            return new House();
        }

        public static House LayFoundations(this House house, House.Foundation foundation) 
        {
            house.Foundations = foundation;
            return house;
        }

        public static House BuildWalls(this House house, House.Wall wall)
        {
            house.Walls = wall;
            return house;
        }
    }
}
