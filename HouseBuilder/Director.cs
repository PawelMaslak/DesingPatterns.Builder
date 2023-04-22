using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.HouseBuilder.Abstraction;

namespace Builder.HouseBuilder
{
    public class Director
    {
        private IHouseBuilder _builder;

        public Director(IHouseBuilder builder)
        {
            _builder = builder;
        }

        public void ChangeBuilder(IHouseBuilder newBuilder)
        {
            _builder = newBuilder;
        }

        public void BuildHouse()
        {
            _builder.Reset();

            _builder.SetBasicInfo();
            _builder.LayFoundations();
            _builder.BuildWalls();
            _builder.FitWindows();
            _builder.BuildRoof();

            _builder.BuildExtras();
        }
    }
}
