using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.Composite
{
    public class FileItem : IFileSystemItem
    {
        private readonly string _name;

        public FileItem(string name)
        {
            _name = name;
        }

        public void Display(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)}File: {_name}");
        }
    }
}
