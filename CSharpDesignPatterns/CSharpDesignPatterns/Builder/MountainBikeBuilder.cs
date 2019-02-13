using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Builder
{
    public class MountainBikeBuilder : BikeBuilder


    { /* Class object of AbstractMountainBike 
        is assigned by the constructor and
        retrieved by the property Bicycle
         */
        private AbstractMountainBike _mountainBikeInProgress;
        /* property of MountainBikeBuilder used to return an object of IBicycle.
            The object is of type AbstractMountainBike that implements 
            the IBicycle interface.
         */
        public override IBicycle Bicycle
        {
            get
            {
                return _mountainBikeInProgress;
            }
        }
        /* Constructor of the class RoadBikeBuilder 
         * that takes a parameter of AbstractRoadBike
         and assigns that parameter to the class field 
         _roadBikeInProgress*/
        public MountainBikeBuilder(AbstractMountainBike mountainBike)
        {
            this._mountainBikeInProgress = mountainBike;
        }

        /*Method , public access modifier. 
         * Override used to define it's behavior
         * instead of the parent class that it extends.
         void - no return type.*/
        public override void BuildWideTires()
        {
            Console.WriteLine("Building MountainBike Wide Tires.");
        }

        public override void BuildHandleBars()
        {
            Console.WriteLine("Building MountainBike Handle Bars");
        }
    }
}
