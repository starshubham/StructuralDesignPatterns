using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.Flyweight
{
    public class TreeType
    {
        public string Name { get; }

        public string Color { get; }

        public TreeType(string name, string color)
        {
            Name = name;
            Color = color;

            Console.WriteLine($"Created TreeType: {Name} - {Color}");
        }

        public void Display(int x, int y)
        {
            Console.WriteLine(
                $"Tree: {Name}, Color: {Color}, " +
                $"Position: ({x}, {y})");
        }
    }
}
