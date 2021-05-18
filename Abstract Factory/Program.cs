using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose your Animal:");
            Console.WriteLine("Meat Eating Animal: 'M'");
            Console.WriteLine("Grass Eating Animal: 'G'");
            Console.Write("Choice:"); string choice = Console.ReadLine();
            AbstractFactory abstractFactory = null;
            if (choice == "M")
            {
                abstractFactory = new Animal();
                abstractFactory.CreateMeatEater();
            Console.WriteLine(abstractFactory.CreateGrassEater().Name);
            Console.WriteLine(abstractFactory.CreateGrassEater().LifeTime.ToString());
            Console.WriteLine(abstractFactory.CreateGrassEater().Voice);
            }
            else if (choice == "G")
            {
                abstractFactory = new Animal();
                abstractFactory.CreateGrassEater();
            Console.WriteLine(abstractFactory.CreateMeatEater().Name);
            Console.WriteLine(abstractFactory.CreateMeatEater().LifeTime.ToString());
            Console.WriteLine(abstractFactory.CreateMeatEater().Voice);
            }
        }

    }
}