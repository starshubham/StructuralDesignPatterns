using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.Composite
{
    public class Folder : IFileSystemItem
    {
        private readonly string _name;
        private readonly List<IFileSystemItem> _items;

        public Folder(string name)
        {
            _name = name;
            _items = new List<IFileSystemItem>();
        }

        public void Add(IFileSystemItem item)
        {
            _items.Add(item);
        }

        public void Remove(IFileSystemItem item)
        {
            _items.Remove(item);
        }

        public void Display(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)}Folder: {_name}");
            foreach (var item in _items)
            {
                item.Display(indent + 4);
            }
        }
    }
}
