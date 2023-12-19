using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomApp.Entity
{
    public class OrderItems
    {

        int orderItemsId;
        int orderId;
        int productId;
        int quantity;

        public OrderItems() { }
        public OrderItems(int orderItemsId, int orderId, int productId, int quantity)
        {
            this.orderItemsId = orderItemsId;
            this.orderId = orderId;
            this.productId = productId;
            this.quantity = quantity;
        }

        public int OrderItemsId
        {
            get { return orderItemsId; }
            set { orderItemsId = value; }
        }
        public int OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }
        public int ProductId
        {
            get { return productId; }
            set { productId = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public override string ToString()
        {
            return $"orderItemId : {orderItemsId}, orderId : {orderId}, productId : {productId}, quantity : {quantity}";
        }
    }
}
