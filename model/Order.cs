using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenApp.model
{
    public class Order
    {
        public int tableNumber { get; set; }
        public Recipe recipe { get; set; }

        public Order(int tableNumber, Recipe recipe)
        {
            this.tableNumber = tableNumber;
            this.recipe = recipe;
        }
    }
}
