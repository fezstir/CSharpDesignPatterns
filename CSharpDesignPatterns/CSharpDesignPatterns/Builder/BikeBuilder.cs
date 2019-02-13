using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns; // need access to namespace

namespace Builder
{
    public abstract class BikeBuilder
    {// Property of IBicycle called Bicycle
        public abstract IBicycle Bicycle { get; }

        /*  virtual keyword used to optionally override in child class
         Void means No return type*/
        public virtual void BuildStreetTires() { }

        public virtual void BuildWideTires() { }

        public virtual void BuildHandleBars() { }
    }
}
