using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticTest_
{
    class Manufacory
    {
        public string Name { get; set; }

        public Manufacory(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
    class ManufactoryFactory
    {
        public Manufacory Create(string name)
        {
            return new Manufacory(name);
        }
    }
    class StaticClass
    {
        public static ManufactoryFactory Factory => new ManufactoryFactory();
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var factory1 = StaticClass.Factory.Create("factory1");
            Console.WriteLine(factory1);

            var factory2 = StaticClass.Factory.Create("factory2");
            Console.WriteLine(factory2);
        }
    }
}
