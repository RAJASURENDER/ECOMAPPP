using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomApp.Entity
{
    public class Orders
    {

        int orderId;
        int customerId;
        DateTime orderDate;
        double totalPrice;
        string shippingAddress;

        public Orders() { }
        public Orders(int orderId, int customerId, DateTime orderDate, double totalPrice, string shippingAddress)
        {
            this.orderId = orderId;
            this.customerId = customerId;
            this.orderDate = orderDate;
            this.totalPrice = totalPrice;
            this.shippingAddress = shippingAddress;
        }

        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }

        public int CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        public double TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }

        public string ShippingAddress
        {
            get { return shippingAddress; }
            set { shippingAddress = value; }
        }

        public override string ToString()
        {
            return $"OrderId : {orderId} , CustomerId : {customerId} , OrderDate : {orderDate} , " +
                $"TotalPrice : {totalPrice} , ShippingAddress : {shippingAddress}";
        }
    }
}
