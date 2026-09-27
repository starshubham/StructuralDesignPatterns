using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.Decorator
{
    public interface ICoffee
    {
        string GetDescription();
        decimal GetCost();
    }
}
