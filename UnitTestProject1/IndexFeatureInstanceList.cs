using CSharpIndexFeatureExplore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    /// <summary>
    /// Summary description for IndexFeatureInstanceList
    /// </summary>
    [TestClass]
    public class IndexFeatureInstanceList
    {

        private Customer _customer;

        [TestInitialize()]
        public void TestInit()
        {
            this._customer = new Customer(5) { };

            this.Initialize_Customer_Collection();
        }

        private void Initialize_Customer_Collection()
        {
            this._customer[0] = new Customer { Title = Title.MR, FirstName = "Red", LastName = "Ford" };
            this._customer[1] = new Customer { Title = Title.MS, FirstName = "Anne", LastName = "Green" };
            this._customer[2] = new Customer { Title = Title.MR, FirstName = "Jack", LastName = "Robinsons" };
            this._customer[3] = new Customer { Title = Title.MS, FirstName = "Michelle", LastName = "Miguelito" };
            this._customer[4] = new Customer { Title = Title.MS, FirstName = "Trix", LastName = "Delacruz" };
        }

        [TestMethod]
        [Priority(1)]
        public void Test_Create_Instances_Of_Customer_Class()
        {

            Assert.IsNotNull(_customer);
            Assert.IsTrue(_customer.CustomersLength > 0);
            
        }

        [TestMethod]
        [Priority(2)]
        public void Test_Loop_Throught_Customer_Instances()
        {
            int length = this._customer.CustomersLength;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(this._customer[i].ToString());
            }
        }
    }
}
