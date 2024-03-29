﻿using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents
{
    public class CategoryComponent:ViewComponent
    {
        ICategoryService _categoryService;

        public CategoryComponent(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _categoryService.GetAll();
            return View(result);
        }
    }
}
