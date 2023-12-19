using EcomApp.Dao;
using EcomApp.Entity;
using System.Data.Common;

namespace EcommerceSystem
{
    public class Tests
    {
        private const string connectionString = "Server=DESKTOP-SN5DBT4;Database=ECOMM;Trusted_Connection=True";

        [Test]
        public void GetAllFromCart()
        {
            IOrderProcessorRepository repo = new OrderProcessorRepositoryImpl();

            Customers customer = new Customers();
            customer.CustomerId = 1;

            var allProduct = repo.GetAllFromCart(customer);
            Console.WriteLine();

            Assert.IsNotNull(allProduct);
            Assert.GreaterOrEqual(customer.CustomerId, 0);
        }

        [Test]
        public void CreateProduct()
        {
            IOrderProcessorRepository repo = new OrderProcessorRepositoryImpl();
            Products product = new Products();
            product.Name = "testproduct";
            product.Price = 21;
            product.Description = "Description for testproduct";
            product.StockQuantity = 1;

            var addProduct = repo.CreateProduct(product);

            Assert.AreEqual(true, addProduct);
        }

        [Test]
        public void AddToCart()
        {
            IOrderProcessorRepository repo = new OrderProcessorRepositoryImpl();
            Products product = new Products();
            Customers customers = new Customers();

            customers.CustomerId = 6;
            product.ProductId = 2;
            int quantity = 1;
            var addTocart = repo.AddToCart(customers, product, quantity);

            Assert.AreEqual(true, addTocart);

        }

        [Test]
        public void PlaceOrder()
        {
            IOrderProcessorRepository repo = new OrderProcessorRepositoryImpl();
            Products product = new Products();
            Customers customers = new Customers();
            Dictionary<Products, int> dict = new Dictionary<Products, int>();

            customers.CustomerId = 6;
            product.ProductId = 1;
            int quantity = 1;
            string shippingAddress = "123 Teststreet";
            dict.Add(product, quantity);

            var placeOrder = repo.PlaceOrder(customers, dict, shippingAddress);

            Assert.AreEqual(true, placeOrder);
        }

        [Test]
        public void CorrectException()
        {
            IOrderProcessorRepository repo = new OrderProcessorRepositoryImpl();

            int customerId = 1;
            int productId = 4;

            var customerExists = repo.doCustomerExists(customerId);
            var productExists = repo.doProductExists(customerId);

            Assert.AreEqual(true, customerExists);
            Assert.AreEqual(true, productExists);
        }
    }
}