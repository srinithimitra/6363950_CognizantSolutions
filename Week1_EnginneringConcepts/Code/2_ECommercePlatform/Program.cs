using System;

class Program
{
    static void Main()
    {
        
        Product[] products = new Product[]
        {
            new Product(105, "Laptop", "Electronics"),
            new Product(101, "Shoes", "Footwear"),
            new Product(103, "Book", "Education"),
            new Product(102, "Phone", "Electronics"),
            new Product(104, "Pen", "Stationery")
        };

        
        var sortedProducts = products.OrderBy(p => p.ProductId).ToArray();

        int searchId = 103;

     
        var resultLinear = SearchFunctions.LinearSearch(products, searchId);
        Console.WriteLine("Linear Search Result:");
        Console.WriteLine(resultLinear != null ? resultLinear.ToString() : "Product not found");

        
        var resultBinary = SearchFunctions.BinarySearch(sortedProducts, searchId);
        Console.WriteLine("\nBinary Search Result:");
        Console.WriteLine(resultBinary != null ? resultBinary.ToString() : "Product not found");

        
        Console.WriteLine("\nAnalysis:");
        Console.WriteLine("Linear Search Time Complexity: O(n)");
        Console.WriteLine("Binary Search Time Complexity: O(log n)");
        Console.WriteLine("Binary Search is more suitable when the array is sorted.");
    }
}
