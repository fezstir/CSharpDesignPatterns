using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;
using Builder;
using Singleton;
using Adapter;
using Decorator;

namespace CSharpDesignPatterns

{
    class Program
    {

        static void Main(string[] args)
        {
            //AbstractFactoryDemo();
            //BuilderPatternDemo();
            //SingletonPatternDemo();
            //AdapterPatternDemo();
            DecoratorPatternDemo();
        }

        private static void DecoratorPatternDemo()
        {
            //standard touring bike
            IBicycle myTourbike = new Touring(new NarrowWheel(24));
            Console.WriteLine(myTourbike);

            //touring bikewith custome grips
            myTourbike = new CustomGripOption(myTourbike);
            Console.WriteLine(myTourbike);

            //touring bike with leather seat
            myTourbike = new LeatherSeatOption(myTourbike);
            Console.WriteLine(myTourbike);
        }

        private static void AdapterPatternDemo()
        {
            IList<IWheel> wheels = new List<IWheel>();
            wheels.Add(new NarrowWheel(24));
            wheels.Add(new WideWheel(20));
            wheels.Add(new NarrowWheel(26));
            wheels.Add(new UltraWheelAdapter(new UltraWheel(28)));

            foreach (IWheel wheel in wheels)
            {
                Console.WriteLine(wheel);
            }

            // The Results would be the following:

            //NarrowWheel with a wheel size of 24 inches
            //NarrowWheel with a wheel size of 20 inches
            //WideWheel with a wheel size of 24 inches
        }
        private static void SingletonPatternDemo()
        {
            SerialNumberGenerator generator = SerialNumberGenerator.Instance;
            Console.WriteLine("nextserial" + generator.NextSerial);
            Console.WriteLine("next serial" + SerialNumberGenerator.Instance.NextSerial);
            Console.WriteLine("next serial" + generator.NextSerial);
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
