using System;

namespace random_number_service
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generating 52 element array containing the numbers between 1 to 52 in random order.");
            var collection = new RandomIntCollectionGenerator().Generate(1, 52);
            collection.ForEach(Console.WriteLine);
        }
    }
}
