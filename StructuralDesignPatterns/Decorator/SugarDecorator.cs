using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.Decorator
{
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + ", Sugar";
        }

        public override decimal GetCost()
        {
            return _coffee.GetCost() + 10;
        }
    }
}
