using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;

namespace Visitor
{
    public class WheelDiagnostics : IWheelVisitor
    {
        public void Visit(IWheel wheel)
        {
            Console.WriteLine("Diagnosing the wheel");
        }

        public void Visit(Spokes spokes)
        {
            Console.WriteLine("Diagnosing the spokes");
        }

        public void Visit(Bearings bearings)
        {
            Console.WriteLine("Diagnosing the bearings");
        }
    }
}
