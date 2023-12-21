using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenApp.model
{
    public class KitchenMaterial : Material
    {
        public KitchenMaterial(String name, int quantity, Image sprite) : base(name, quantity)
        {
            SetSprite("normal", sprite);
        }
    }
}
