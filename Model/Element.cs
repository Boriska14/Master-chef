using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalleCode.Model
{
    public class Element
    {
        public Image sprite { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public Element(Image sprite) {
            this.sprite = sprite;
            this.x = 0;
            this.y = 0;
        }
    }
}
