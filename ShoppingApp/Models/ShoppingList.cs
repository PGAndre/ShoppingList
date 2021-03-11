using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingApp.Models;

namespace ShoppingApp.Models
{
    public class ShoppingList
    {
        public int Id { get; set; }
        public List<Product> Products { get; set; }
    }
}
