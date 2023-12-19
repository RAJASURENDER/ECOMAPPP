

using EcomApp.Entity;
using EcomApp.Dao;


IOrderProcessorRepository impl = new OrderProcessorRepositoryImpl();
IServiceRepo service = new ServiceRepo();

int choice = 0;
int i = 1;
do
{
    Console.WriteLine( "\n\n------------------WELCOME TO ECOMMERCE APP-------------------\n");
    Console.WriteLine("ENTER 1: REGISTER CUSTOMER\n" +
    "\nENTER 2: CREATE PRODUCT\n" +
    "\nENTER 3: DELETE PRODUCT\n" +
    "\nENTER 4: ADD TO CART\n" +
    "\nENTER 5: VIEW CART\n" +
    "\nENTER 6: PLACE ORDER\n" +
    "\nENTER 7: VIEW CUSTOMER ORDER\n" +
    "\nENTER 0 to EXIT");
    choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 0:
            i = 0;
            break;
        case 1:
            service.CreateCustomer();
            break;
        case 2:
            service.CreateProduct();
            break;
        case 3:
            service.DeleteProduct();
            break;
        case 4:
            service.AddToCart();
            break;
        case 5:
            service.ProductInCart();
            break;
        case 6:
            service.PlaceOrder();
            break;
        case 7:
            service.GetOrderByCustomer();
            break;
        default:
            Console.WriteLine("\n-----Invalid Input-----Please enter valid key---");
            break;
    }
    Console.WriteLine("\n\nEnter 0 to exit or any other key to continue...");
    
    if (choice == 0)
        break;
} while (i > 0);