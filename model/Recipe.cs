using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenApp.model
{
    public class Recipe
    {
        public string name { get; set; }
        public Commodity[] commodities { get; set; }
        public RecipeTask[] recipeTasks { get; set; }

        public Recipe(string name, Commodity[] commodities, RecipeTask[] recipeTasks)
        {
            this.name = name;
            this.commodities = commodities;
            this.recipeTasks = recipeTasks;
        }
    }
}
