using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenApp.model
{
    public class Washer : KitchenEmployee
    {
        public Washer()
        {
            x = 7;
            y = 4;
            SetSprite("moving-left", Image.FromFile("C:\\Users\\amoug\\Documents\\App\\KitchenApp\\assets\\employees\\washer\\moving-left.png"));
            SetSprite("moving-right", Image.FromFile("C:\\Users\\amoug\\Documents\\App\\KitchenApp\\assets\\employees\\washer\\moving-right.png"));
            currentSprite = GetSprite("moving-left");
        }
    }
}
