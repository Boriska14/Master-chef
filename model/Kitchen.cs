using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenApp.model
{
    public class Kitchen
    {

        public KitchenMaterial[,] map { get; set; }

        public Kitchen()
        {
            map = new KitchenMaterial[11, 10];
        }

    }
}
