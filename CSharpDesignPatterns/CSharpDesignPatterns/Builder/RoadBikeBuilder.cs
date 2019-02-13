using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns; //we need access to this namespace

namespace Builder
{
    public class RoadBikeBuilder : BikeBuilder
    { /* Class object of AbstractRoadBike 
        is assigned by the constructor and
        retrieved by the property Bicycle
         */
        private AbstractRoadBike _roadBikeInProgress;
        /* property of RoadBikeBuilder used to return an object of IBicycle.
            The object is of type AbstractRoadBike that implements 
            the IBicycle interface.
         */
        public override IBicycle Bicycle
        {
            get
            {
                return _roadBikeInProgress;
            }
        }
        /* Constructor of the class RoadBikeBuilder 
         * that takes a parameter of AbstractRoadBike
         and assigns that parameter to the class field 
         _roadBikeInProgress*/
        public RoadBikeBuilder(AbstractRoadBike roadBike)
        {
            this._roadBikeInProgress = roadBike;
        }

        /*Method , public access modifier. 
         * Override used to define it's behavior
         * instead of the parent class that it extends.
         void - no return type.*/
        public override void BuildStreetTires()
        {
            Console.WriteLine("Building RoadBike Street Tires.");
        }

        public override void BuildHandleBars()
        {
            Console.WriteLine("Building RoadBike Handle Bars");
        }
    }
}
