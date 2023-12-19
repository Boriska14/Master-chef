using SalleCode.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public abstract class Table : Element
    {
        public int nbre_place { get; set; }
     
        public Table(Image sprite, int nbre_place):base(sprite)
        {
            this.nbre_place = nbre_place;
        }


    }
}
