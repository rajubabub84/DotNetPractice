using ShoppingCart.Implementation;
using ShoppingCart.Interfaces;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingFacade
{
    public class UserOrder : IUserOrder
    {
        public int AddToCart(int itemID, int quantity)
        {
            Console.WriteLine("Start Add to cart");
            ICart userCart = new ShoppingCartDetails();
            int cartID = 0;
            //Step 1: GetItem
            Product product = userCart.GetItemDetails(itemID);
            //Step 2: CheckAvailability
            if(userCart.CheckItemAvailability(product))
            {
                //Step 3: LockItemInStock
                userCart.LockItemInStock(itemID, quantity);
                //Step 4: AddItenToCart
                cartID = userCart.AddItemToCart(itemID, quantity);
            }
            Console.WriteLine("EndAddToCart");
            return cartID;

        }

        public int PlaceOrder(int cartID, int userID)
        {
            Console.WriteLine("Start Place Order Details");
            int orderID = -1;
            IWallet wallet = new Wallet();
            ITax tax = new Tax();
            ICart userCart = new ShoppingCartDetails();
            IAddress address = new AddressDetails();
            IOrder order = new Order();
            //Step 1: Get Tax Percentage by State
            double stateTax = tax.GetTaxByState("ABC");
            //Step 2: Apply Tax on Cart Items
            tax.ApplyTax(cartID, stateTax);
            //Step 3: Get User Wallet Balance
            double userWalletBalance = wallet.GetUserBalance(userID);
            //Step 4: Get Cart Items Price
            double cartPrice = userCart.GetCartPrice(cartID);
            //Step 5: Compare the balance and price
            if (userWalletBalance > cartPrice)
            {
                //Step 6: Get User Address and set to Cart
                Address userAddress = address.GetAddressDetails(userID);
                //Step 7: Place the order
                orderID = order.PlaceOrderDetails(cartID, userAddress.AddressID);
            }
            Console.WriteLine("End Place Order Details");
            return orderID;
        }
    }
}
