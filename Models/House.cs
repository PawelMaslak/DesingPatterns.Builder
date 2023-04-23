using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Models
{
    public class House
    {
        public string Type { get; set; }
        public Foundation Foundations { get; set; }
        public Wall Walls { get; set; }
        public Roof RoofCovering { get; set; }
        public Window Windows { get; set; }
        public SwimmingPool HouseSwimmingPool { get; set; }
        public bool HasSwimmingPool { get; set; }
        public class Foundation
        {
            public string Material { get; set; } = string.Empty;
            public int ConcreteAmount { get; set; }
        }

        public class Wall
        {
            public string Material { get; set; } = string.Empty;
            public int TotalLength { get; set; }
        }

        public class Roof
        {
            public string Material { get; set; } = string.Empty;
            public int Area { get; set; }
        }

        public class Window
        {
            public int Amount { get; set; }
        }

        public class SwimmingPool
        {
            public int Area { get; set; }
        }
    }
}
