using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PACS.Data.Interfaces;
using PACS.Data.Models;
using PACS.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PACS.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IRocketRepository _rocketRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IRocketRepository rocketRepository, ShoppingCart shoppingCart)
        {
            _rocketRepository = rocketRepository;
            _shoppingCart = shoppingCart;
        }

        [Authorize]
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

        [Authorize]
        public RedirectToActionResult AddToShoppingCart(int rocketId)
        {
            var selectedRocket = _rocketRepository.Rockets.FirstOrDefault(p => p.RocketId == rocketId);
            if (selectedRocket != null)
            {
                _shoppingCart.AddToCart(selectedRocket, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int rocketId)
        {
            var selectedRocket = _rocketRepository.Rockets.FirstOrDefault(p => p.RocketId == rocketId);
            if (selectedRocket != null)
            {
                _shoppingCart.RemoveFromCart(selectedRocket);
            }
            return RedirectToAction("Index");
        }

    }
}
