using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var VAZFactory = new VAZFactory();
            PrintCarInformation(VAZFactory);

            var LadaFactory = new LadaFactory();
            PrintCarInformation(LadaFactory);

        }

        static void PrintCarInformation(ICarFactory factory)
        {
            Console.WriteLine("----YEAH!----");
            var door = factory.GetDoor();
            Console.WriteLine("You have {0}", door.Name);
            var engine = factory.GetEngine();
            Console.WriteLine("With {0} that has {1} horse powers!", engine.Name, engine.Power);
            var interior = factory.GetInteroir();
            Console.WriteLine("And finally your interior is {0} / 10", interior.Beautiness);
            Console.WriteLine("We call that interior {0}", interior.Name);
            Console.WriteLine("It was {0}", factory.GetType().ToString());
            Console.WriteLine("----See you again!----");
            Console.WriteLine();
        }
    }
}
