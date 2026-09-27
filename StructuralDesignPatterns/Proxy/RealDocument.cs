using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.Proxy
{
    public class RealDocument : IDocument
    {
        public RealDocument()
        {
            Console.WriteLine("RealDocument object created.");
        }

        public void Read()
        {
            Console.WriteLine("Reading confidential document...");
        }
    }
}
