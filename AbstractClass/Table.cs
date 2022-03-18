using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class Table:Furniture
    {
        public string Material;
        public Table(string material,string color):base(color)
        {
            Material = material;
        }

        public override void Info()
        {
            Console.WriteLine($"Material: {Material} Color: {Color}");
        }
    }
}
