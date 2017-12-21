using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
    }

    public class ItemList
    {
        public string Title { get; set; }
        public  List<Item> Items { get; set; }

        public ItemList()
        {
            Items = new List<Item>();
        }
    }
}