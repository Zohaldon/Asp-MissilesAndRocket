using Microsoft.AspNetCore.Mvc;
using PACS.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PACS.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.Categories.OrderBy(p => p.CategoryName);
            return View(categories);
        }
    }
}
