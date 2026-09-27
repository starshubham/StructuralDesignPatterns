using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.Decorator
{
    public class SimpleCoffee : ICoffee
    {
        public string GetDescription()
        {
            return "Simple Coffee";
        }

        public decimal GetCost()
        {
            return 100;
        }
    }
}
