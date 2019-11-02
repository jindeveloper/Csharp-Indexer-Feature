using CSharpIndexFeatureExplore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{

    [TestClass]
    public class IndexFeaturesRepresentsList
    {

        private Food _food;


        [TestInitialize()]
        public void Init()
        {
            this._food = new Food();
        }

        [TestMethod]
        public void Test_Get_FoodPyramid()
        {
            var foodTypes = (FoodType[])Enum.GetValues(typeof(FoodType));

            foreach (var foodType in foodTypes)
            {
                var results = this._food[foodType, foodType.ToString()];

                Assert.IsNotNull(results);

                Assert.IsTrue(results.Length > 0);

                foreach (var food in results)
                {
                    Console.WriteLine($"{foodType.ToString()} => {food} ");
                }
            }
        }

        [TestMethod]
        [ExpectedException(typeof(KeyNotFoundException))]
        public void Test_Get_FoodPyramid_Not_Exists()
        {
            var food = this._food[(FoodType)3];
        }

        [TestMethod]
        public void Test_Get_FoodPyramid_Not_Exists_Handle()
        {
            Exception expectedException = null;

            try
            {
                var food = this._food[(FoodType)4];
            }
            catch (Exception ex)
            {
                expectedException = ex;
            }

            Assert.IsNotNull(expectedException);
        }

    }
}
