using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.Flyweight
{
    public class TreeFactory
    {
        private readonly Dictionary<string, TreeType> _treeTypes = new Dictionary<string, TreeType>();

        public TreeType GetTreeType(string name, string color)
        {
            string key = $"{name}_{color}";

            if (!_treeTypes.ContainsKey(key))
            {
                _treeTypes[key] = new TreeType(name, color);
            }

            return _treeTypes[key];
        }

        public int GetTreeTypeCount()
        {
            return _treeTypes.Count;
        }
    }
}
