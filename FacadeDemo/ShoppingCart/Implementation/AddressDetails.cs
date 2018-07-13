using ShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingCart.Models;

namespace ShoppingCart.Implementation
{
    public class AddressDetails : IAddress
    {
        public Address GetAddressDetails(int UserID)
        {
            Console.WriteLine("\t SubSysttem Address: GetAddressDetails");
            return new Address();
        }
    }
}
