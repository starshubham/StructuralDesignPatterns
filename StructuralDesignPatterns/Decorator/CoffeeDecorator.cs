using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.Decorator
{
    public abstract class CoffeeDecorator : ICoffee
    {
        protected readonly ICoffee _coffee;

        public CoffeeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public abstract string GetDescription();

        public abstract decimal GetCost();
    }
}
