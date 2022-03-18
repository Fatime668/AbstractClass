using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    abstract class Furniture
    {
        public string Color;
        public Furniture(string color)
        {
            Color = color;
        }
        public abstract void Info();
    }
}
