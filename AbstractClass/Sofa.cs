using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class Sofa:Furniture
    {
        public string Fabric;
        public Sofa(string fabric,string color):base(color)
        {
            Fabric = fabric;
        }

        public override void Info()
        {
            Console.WriteLine($"Fabric {Fabric} Color: {Color}");
        }
    }
}
