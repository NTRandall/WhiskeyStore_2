using System.Collections.Generic;
using WhiskeyStore_2.Models;

namespace WhiskeyStore_2.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}