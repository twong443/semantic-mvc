using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult Index()
        {
            var itemList = new ItemList { Title = "Item Things!" };

            var random = new Random();

            for (int i = 1; i < 50; ++i)
                itemList.Items.Add(new Item { Id = i, Name = $"Item {random.Next()}", Created = DateTime.Today.AddDays(i).Date });

            return View(itemList);
        }   
    }       
}           