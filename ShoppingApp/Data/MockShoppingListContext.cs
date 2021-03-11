using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingApp.Models;

namespace ShoppingApp.Data
{
    public class MockShoppingListContext : IShoppingListContext

    {

        List<Product> _products;
        ShoppingList _shoppinglist;
        List<ShoppingList> _shoppingLists;
        public MockShoppingListContext()
            
        {
            var products = new List<Product>
            {
            new Product { Id = 0, Name = "green apple", Price = 7.8M, Category = "fruits" },
            new Product { Id = 1, Name = "red apple", Price = 7.8M, Category = "fruits" },
            new Product { Id = 2, Name = "beef", Price = 7.8M, Category = "food" },
            new Product { Id = 3, Name = "milk", Price = 7.8M, Category = "food" },
            new Product { Id = 4, Name = "Alenka", Price = 7.8M, Category = "sweets" }
            };


            ShoppingList shoppinglist = new ShoppingList { Id = 0 };
            _products = products;
            _shoppinglist = shoppinglist;
            _shoppingLists.Add(shoppinglist);
        }

        public void AddProductToList(int productId, int shoppinglistId)
        {
            Product Myproduct = (from product in _products
                                where product.Id == 0
                                select product).First();
            _shoppinglist.Products.Add(Myproduct);
        }

        public ShoppingList CreateShoppingList()
        {
            ShoppingList shoppinglist2 = new ShoppingList { Id = 1 };
            return shoppinglist2;
        }
        
        public Product GetProductById(int id)
        {
            return(from Product product in _products
                    where product.Id == id
                    select product).First();
        }

        public List<Product> GetProductByName(string name)
        {
            return  (from Product product in _products
                           where product.Name.Contains(name)
                           select product).ToList();
        }

        public void RemoveProductFromList(int productId, int shoppinglistId)
        {
          var  MyshoppingList = (from ShoppingList shList  in _shoppingLists
                             where shList.Id == shoppinglistId
                                select shList).First();
          var Myproduct = (from Product product in _products
                           where product.Id == productId
                           select product).First();
            MyshoppingList.Products.Remove(Myproduct);
        }
    }
}
