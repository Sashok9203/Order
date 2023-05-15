using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    internal class UserOrder
    {
        public static int OrderNumber { get; private set; } 

        public Product? Drink { get; }

        public Product? Dish { get; }

        public Product? Dessert { get; }

        public DateTime OrderDate { get; }

        public UserOrder(Product? drink,Product? dish,Product? dessert)
        {
            OrderNumber++;
            Drink = drink;
            Dish = dish;
            Dessert = dessert;
            OrderDate = DateTime.Now;
        }

        public double OrderPrice => (Drink?.Price ?? 0) + (Dessert?.Price ?? 0) + (Dish?.Price ?? 0);

        public override string ToString() => $"{OrderDate} | Замовлення № {OrderNumber} | Ціна {OrderPrice} гр.";
       
    }
}
