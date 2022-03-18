using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Sofa sofa = new Sofa("Leather", "White");
            Table table = new Table("Wooden","Brown");
            sofa.Info();
            table.Info();
        }
    }
}
