using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using webshop.Models;

namespace webshop.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            var categoryList = new List<Category>
            {
                new Category { Name="Electronics"},
                new Category { Name="Food"},
                new Category { Name="Furniture"},
            };
            return View(categoryList);
        }

        public ActionResult Browse(string category)
        {
            var categoryModel = new Category { Name = category };
            return View(categoryModel);
        }

        public ActionResult Details(int id)
        {
            var item = new Item
            {
                Title = "item" + id
            };
            return View(item);
        }
    }
}