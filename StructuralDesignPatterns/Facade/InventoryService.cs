using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPatterns.Facade
{
    public class InventoryService
    {
        public bool CheckStock(int productId)
        {
            Console.WriteLine($"Checking inventory for Product ID: {productId}");

            List<int> ProductIdList = new List<int> { 101, 102, 103, 104, 105 };

            return ProductIdList.Contains(productId);
        }
    }
}
