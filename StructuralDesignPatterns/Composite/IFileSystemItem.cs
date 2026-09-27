using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.Composite
{
    public interface IFileSystemItem
    {
        void Display(int indent = 0);
    }
}
