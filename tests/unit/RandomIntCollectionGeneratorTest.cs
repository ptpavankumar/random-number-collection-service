using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

using random_number_service;

namespace Tests
{
    public class RandomIntCollectionGeneratorTest
    {
        RandomIntCollectionGenerator generator;
        List<int> collection;

        int minimumNumberInCollection;
        int maximumNumberInCollection;

        [SetUp]
        public void Setup()
        {
            minimumNumberInCollection = 1;
            maximumNumberInCollection = 56;
            generator = new RandomIntCollectionGenerator();
            collection = generator.Generate(minimumNumberInCollection, maximumNumberInCollection);
        }

        [Test]
        public void Fixed_List_Of_Numbers_Generated()
        {
            Assert.AreEqual(maximumNumberInCollection - 1, collection.Count);
        }

        [Test]
        public void Numbers_Generated_Are_Unique_In_Collection()
        {
            Assert.AreEqual(maximumNumberInCollection - 1, collection.Distinct().ToList().Count);
        }
    }
}