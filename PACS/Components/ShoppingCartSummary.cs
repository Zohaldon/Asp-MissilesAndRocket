using Microsoft.AspNetCore.Mvc;
using PACS.Data.Models;
using PACS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PACS.Components
{
    public class ShoppingCartSummary : ViewComponent
    {
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        // It will automatically used each time our component is involked
        public IViewComponentResult Invoke()
        {
            // var items = new List<ShoppingCartItem>() { new ShoppingCartItem(), new ShoppingCartItem() };
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }
    }
}
