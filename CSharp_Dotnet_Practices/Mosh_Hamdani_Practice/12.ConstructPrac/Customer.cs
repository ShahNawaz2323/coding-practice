using System.Collections.Generic;
namespace ConstructPrac
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;   
        public Customer()
        {
            Orders = new List<Order>(); //initialize new order empty list
        }
        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            //this.Id = id;
            this.Name = name;
        }
    }
}
