using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;
using Builder;

namespace CSharpDesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            //AbstractFactoryDemo();
            BuilderPatternDemo();
        }
        private static void BuilderPatternDemo()
        {
            AbstractMountainBike mountainBike =
                new Downhill(BikeColor.Green, new WideWheel(24));

            BikeBuilder builder = new MountainBikeBuilder(mountainBike);
            BikeDirector director = new MountainBikeDirector();
            IBicycle bicycle = director.Build(builder);
            Console.WriteLine(bicycle);
        }

        private static void AbstractFactoryDemo()
        {/*
            parent class object is created by its child class. 
            This parent class can only see methods that it created.
            It gets all child class types that IT created
            (new methods of child class are not used).
            */
            AbstractBikeFactory factory = new RoadBikeFactory();

            /*create the bike parts
             interface object is created and it calls the factory method that 
             returns that interface. This method creates a new object instance 
             of the Frame or Seat class. These classes implement the calling interface
             */
            IBikeFrame bikeFrame = factory.CreateBikeFrame();
            IBikeSeat bikeSeat = factory.CreateBikeSeat();

            //show what we created
            Console.WriteLine(bikeFrame.BikeFrameParts);
            Console.WriteLine(bikeSeat.BikeSeatParts);
        }
    }
}
