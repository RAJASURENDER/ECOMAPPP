using EcomApp.Entity;
using System;
using static EcomApp.Dao.ServiceRepo;

namespace EcomApp.Dao
{
        public class ServiceRepo : IServiceRepo
        {
            Customers customer = new Customers();
            Products product = new Products();

            IOrderProcessorRepository impl = new OrderProcessorRepositoryImpl();


            int customerId = 0;
            int productId = 0;
            int quantity = 0;

            public void AddToCart()
            {
                try
                {
                    Console.WriteLine("Enter Customer Id:");
                    customerId = Convert.ToInt32(Console.ReadLine());
                    customer.CustomerId = customerId;
                    Console.WriteLine("Enter product Id:");
                    productId = Convert.ToInt32(Console.ReadLine());
                    product.ProductId = productId;
                    Console.WriteLine("Enter quantity:");
                    quantity = Convert.ToInt32(Console.ReadLine());
                    impl.AddToCart(customer, product, quantity);
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            public void CreateCustomer()
            {
                try
                {
                    Console.WriteLine("Enter your name:");
                    string customerName = Console.ReadLine();
                    customer.Name = customerName;
                    Console.WriteLine("Enter your Email:");
                    string email = Console.ReadLine();
                    customer.Email = email;
                    Console.WriteLine("Enter your password:");
                    string password = Console.ReadLine();
                    customer.Password = password;
                    impl.CreateCustomer(customer);
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            public void CreateProduct()
            {
                try
                {
                    Console.WriteLine("Enter product name:");
                    string productName = Console.ReadLine();
                    product.Name = productName;
                    Console.WriteLine("Enter product price");
                    double productPrice = double.Parse(Console.ReadLine());
                    product.Price = productPrice;
                    Console.WriteLine("Enter product description");
                    string productDescription = Console.ReadLine();
                    product.Description = productDescription;
                    Console.WriteLine("Enter product quantity");
                    int productQuantity = int.Parse(Console.ReadLine());
                    product.StockQuantity = productQuantity;
                    impl.CreateProduct(product);
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

            public void DeleteCustomer()
            {
                throw new NotImplementedException();
            }

            public void DeleteProduct()
            {
                try
                {
                    Console.WriteLine("Enter id to delete product:");
                    productId = Convert.ToInt32(Console.ReadLine());
                    impl.DeleteProduct(productId);
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

            public void GetOrderByCustomer()
            {
                try
                {
                    List<Products> customerOrder = new List<Products>();
                    Console.WriteLine("Enter customer id:");
                    customerId = Convert.ToInt32(Console.ReadLine());
                    customerOrder = impl.GetOrdersByCustomer(customerId);
                    foreach (var items in customerOrder)
                    {
                        Console.WriteLine(items);
                    }
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            }

            public void PlaceOrder()
            {
                try
                {
                    Console.WriteLine("Enter customerId:");
                    customerId = Convert.ToInt32(Console.ReadLine());
                    customer.CustomerId = customerId;
                    Console.WriteLine("Enter productId:");
                    productId = Convert.ToInt32(Console.ReadLine());
                    product.ProductId = productId;
                    Console.WriteLine("Enter quantity");
                    quantity = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter shipping address");
                    string address = Console.ReadLine();

                    Dictionary<Products, int> dict = new Dictionary<Products, int>();
                    dict.Add(product, quantity);
                    impl.PlaceOrder(customer, dict, address);
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            public void ProductInCart()
            {
                try
                {
                    List<Products> productsInCart = new List<Products>();
                    Console.WriteLine("Enter customer Id to view cart:");
                    customerId = Convert.ToInt32(Console.ReadLine());
                    customer.CustomerId = customerId;
                    productsInCart = impl.GetAllFromCart(customer);
                    foreach (var items in productsInCart)
                    {
                        Console.WriteLine(items);
                    }
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }

