using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenApp.contract;

namespace KitchenApp.model
{
    public class PartChef : KitchenEmployee
    {
        public PartChef()
        {
            SetSprite("moving-up", Image.FromFile("C:\\Users\\amoug\\Documents\\App\\KitchenApp\\assets\\employees\\kitchen-clerk\\moving-up.png"));
            SetSprite("moving-down", Image.FromFile("C:\\Users\\amoug\\Documents\\App\\KitchenApp\\assets\\employees\\kitchen-clerk\\moving-down.png"));
            SetSprite("moving-left", Image.FromFile("C:\\Users\\amoug\\Documents\\App\\KitchenApp\\assets\\employees\\kitchen-clerk\\moving-left.png"));
            SetSprite("moving-right", Image.FromFile("C:\\Users\\amoug\\Documents\\App\\KitchenApp\\assets\\employees\\kitchen-clerk\\moving-right.png"));
            SetSprite("working", Image.FromFile("C:\\Users\\amoug\\Documents\\App\\KitchenApp\\assets\\employees\\part-chef\\working.png"));

            currentSprite = GetSprite("moving-up");
        }
    }
}
