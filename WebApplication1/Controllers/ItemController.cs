using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            var random = new Random(999);

            var items = new List<string>();
            for (int i = 1; i < 50; ++i)
                items.Add($"{random.Next()}");

            ViewBag.Items = items;
            return View();
        }   
    }       
}           