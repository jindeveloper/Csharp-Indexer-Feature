using System;
using System.Linq;

namespace CSharpIndexFeatureExplore
{
    public enum Title
    {
        MR = 0,
        MS = 1
    }

    public class Customer
    {
        public Customer() : this(5) {}

        public Customer(int lengthOfCustomers)
        {
            this._customers = new Customer[lengthOfCustomers];
        }
        public Title Title { get; set; }
        public string TitleInString
        {
            get
            {
                string title = Title.ToString();

                return new string(title.Select((ch, index) => (index == 0) ? ch : Char.ToLower(ch)).ToArray());
            }
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int CustomersLength { get { return this._customers.Length; } }

        private readonly Customer[] _customers;
        public Customer this[int index]
        {
            get { return this._customers[index]; }
            set { this._customers[index] = value; }
        }
        public override string ToString() => $"{this.TitleInString}. {this.LastName}, {this.FirstName}";
    }
}
