using System;
using System.Collections.Generic;
using System.Linq;

namespace random_number_service
{
    public class RandomIntCollectionGenerator
    {
        public List<int> Generate(int min, int max)
        {
            var generator = new Random();
            var collection = new List<int>();
            
            while (collection.Count <= (max - 2)) {
                var randomNumber = generator.Next(min, max + 1);
                var alreadyExists = collection.Any(number => number == randomNumber);
                if (!alreadyExists) {
                    collection.Add(randomNumber);
                }
            }

            return collection;
        }
    }
}
