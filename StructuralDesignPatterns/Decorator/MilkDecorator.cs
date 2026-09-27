using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.Decorator
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override string GetDescription()
        {
            return _coffee.GetDescription() + ", Milk";
        }

        public override decimal GetCost()
        {
            return _coffee.GetCost() + 20;
        }
    }
}
