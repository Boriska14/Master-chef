using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KitchenApp.contract;

namespace KitchenApp.model
{
    public class Chef : KitchenEmployee
    {
        public Chef()
        {
            x = 0;
            y = 0;
            SetSprite("waiting", Image.FromFile("C:\\Users\\amoug\\Documents\\App\\KitchenApp\\assets\\employees\\chef\\waiting.png"));
            SetSprite("ready", Image.FromFile("C:\\Users\\amoug\\Documents\\App\\KitchenApp\\assets\\employees\\chef\\ready.png"));

            currentSprite = GetSprite("waiting");
        }
    }
}
