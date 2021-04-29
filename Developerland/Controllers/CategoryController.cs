﻿using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Developerland.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult GetCategoryList()
        {
            var categoryValues = cm.GetAll();
            return View(categoryValues);
        }
        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            cm.CategoryAdd(category);
            return RedirectToAction("GetCategoryList");
        }
    }
}