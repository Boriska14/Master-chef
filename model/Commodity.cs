using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenApp.model
{
    public class Commodity : Entity
    {
        public String name { get; set; }    

        public Commodity(String name)
        {
            this.name = name;
        }
    }
}
