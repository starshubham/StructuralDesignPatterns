using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.Adapter
{
    public interface IPayment
    {
        void Pay(decimal amount);
    }
}
