using EcomApp.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomApp.Dao
{
    

        public interface IOrderProcessorRepository
        {
            public bool CreateProduct(Products product);
            public bool CreateCustomer(Customers customer);
            public bool DeleteProduct(int productId);
            public bool DeleteCustomer(int customerId);
            public bool AddToCart(Customers customer, Products product, int quantity);
          
            public List<Products> GetAllFromCart(Customers customer);
            public bool PlaceOrder(Customers customer, Dictionary<Products, int> dict, string shippingAddress);
            public List<Products> GetOrdersByCustomer(int customerId);
        
            public bool doCustomerExists(int customerid);
            public bool doProductExists(int customerid);
    }
    
}
