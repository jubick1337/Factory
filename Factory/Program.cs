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
            Console.WriteLine("This car has {0} door, {1} engine and {2} INTERIOOOOR!", factory.GetDoor(), factory.GetEngine(), factory.GetInteroir());
        }
    }
}
