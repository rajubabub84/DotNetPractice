using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingFacade
{
    public interface IUserOrder
    {
        int AddToCart(int itemID, int quantity);
        int PlaceOrder(int cartID, int userID);
    }
}
