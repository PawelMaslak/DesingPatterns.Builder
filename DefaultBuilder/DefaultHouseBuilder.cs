using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Models;

namespace Builder.DefaultBuilder
{
    public class DefaultHouseBuilder
    {
        private House _house = new House();

        public DefaultHouseBuilder BuildFoundations(House.Foundation foundation)
        {
            _house.Foundations = foundation;
            return this;
        }

        public DefaultHouseBuilder BuildWalls(House.Wall walls)
        {
            _house.Walls = walls;
            return this;
        }

        public House Build()
        {
            return _house;
        }
    }
}
