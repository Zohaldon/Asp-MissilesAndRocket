using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PACS.Data.Interfaces;
using PACS.Data.Mocks;
using PACS.Data.Models;
using PACS.ViewModels;
namespace PACS.Controllers
{
    public class RocketController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IRocketRepository _rocketRepository;

        public RocketController(ICategoryRepository categoryRepository, IRocketRepository rocketRepository)
        {
            _categoryRepository = categoryRepository;
            _rocketRepository = rocketRepository;
        }

        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Rocket> rockets;

            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                rockets = _rocketRepository.Rockets.OrderBy(p => p.RocketId);
                currentCategory = "All rockets";
            }
            else
            {
                if (string.Equals("Solid-Fueled", _category, StringComparison.OrdinalIgnoreCase))
                {
                    rockets = _rocketRepository.Rockets.Where(p => p.Category.CategoryName.Equals("Solid-Fueled")).OrderBy(p => p.Name);
                }
                else
                    rockets = _rocketRepository.Rockets.Where(p => p.Category.CategoryName.Equals("Liquid-Fueled")).OrderBy(p => p.Name);

                currentCategory = _category;
            }

            return View
            (
                new RocketListViewModel
                {
                    Rockets = rockets,
                    CurrentCategory = currentCategory
                }
            );

        }
    }
}
