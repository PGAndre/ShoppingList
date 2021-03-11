using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingApp.Models;

namespace ShoppingApp.Data
{
    public interface IShoppingListContext
    {
        ShoppingList CreateShoppingList();
        Product GetProductById(int id);
        List<Product> GetProductByName(string name);
        void AddProductToList(int productId, int shoppinglistId);
        void RemoveProductFromList(int productId, int shoppinglistId);


    }
}
