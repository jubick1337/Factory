using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public interface ICarFactory
    {
        IDoor GetDoor();
        IEngine GetEngine();
        IInteroir GetInteroir();
    }

    public class LadaFactory : ICarFactory
    {
        public IDoor GetDoor()
        {
            return new ShittyDoor();
        }

        public IEngine GetEngine()
        {
            return new Engine1920();
        }

        public IInteroir GetInteroir()
        {
            return new BadInterior();
        }
    }

    public class VAZFactory : ICarFactory
    {
        public IDoor GetDoor()
        {
            return new CoolDoor();
        }

        public IEngine GetEngine()
        {
            return new Engine2020();
        }

        public IInteroir GetInteroir()
        {
            return new CoolInterior();
        }
    }

    public interface IDoor
    {
        string Name { get; }
    }

    public interface IEngine
    {
        string Name { get; }
        int Power { get; }
    }

    public interface IInteroir
    {
        string Name { get; }
        double Beautiness { get; }
    }

    class CoolDoor : IDoor
    {
        public string Name => "Wow really cool door";
    }

    class ShittyDoor : IDoor
    {
        public string Name => "Damn what a badass door!";
    }

    class Engine1920 : IEngine
    {
        public string Name => "Old engine";
        public int Power => 20;
    }

    class Engine2020 : IEngine
    {
        public string Name => "Futuristic engine";
        public int Power => int.MaxValue;
    }

    class CoolInterior : IInteroir
    {
        public string Name => "LOOKS GREAT!!!";
        public double Beautiness => 10 / 10;
    }

    class BadInterior : IInteroir
    {
        public string Name => "Nothing to say :(";
        public double Beautiness => 0;
    }
}
