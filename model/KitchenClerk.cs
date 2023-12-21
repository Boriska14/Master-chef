using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenApp.model
{
    public class KitchenClerk : KitchenEmployee
    {
        public KitchenClerk()
        {
            x = 50;
            y = 80;
            SetSprite("moving-up", Image.FromFile("C:\\Users\\amoug\\Documents\\App\\KitchenApp\\assets\\employees\\kitchen-clerk\\moving-up.png"));
            SetSprite("moving-down", Image.FromFile("C:\\Users\\amoug\\Documents\\App\\KitchenApp\\assets\\employees\\kitchen-clerk\\moving-down.png"));
            SetSprite("moving-left", Image.FromFile("C:\\Users\\amoug\\Documents\\App\\KitchenApp\\assets\\employees\\kitchen-clerk\\moving-left.png"));
            SetSprite("moving-right", Image.FromFile("C:\\Users\\amoug\\Documents\\App\\KitchenApp\\assets\\employees\\kitchen-clerk\\moving-right.png"));
            currentSprite = GetSprite("moving-down");
        }
    }
}
