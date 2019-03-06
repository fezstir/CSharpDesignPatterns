﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpDesignPatterns;


namespace Visitor
{
    public class Spokes : IVisitable
    {
        public void AcceptVisitor(IWheelVisitor visitor)
        {
            visitor.Visit(this);

        }
    }
}
