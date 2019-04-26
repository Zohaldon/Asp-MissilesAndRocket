using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PACS.Data.Interfaces;
using PACS.ViewModels;

namespace PACS.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRocketRepository _rocketRepository;

        public HomeController(IRocketRepository rocketRepository)
        {
            _rocketRepository = rocketRepository;
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel()
            {
                PreferredRockets = _rocketRepository.PreferredRockets
            };

            return View(homeViewModel);
        }
    }
}