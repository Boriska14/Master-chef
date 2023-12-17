using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class Salle
    {
        public int width {get; set;}
        public int height { get; set;}
        public List<DesignSol> sol { get; set; }

        public Salle()
        { 
            width = 880; 
            height = 660;
            
            sol = new List<DesignSol>();
            int nbre_width = width / 80;
            int nbre_height = height / 60;
            int  element = nbre_width * nbre_height;

            for  (int i = 0; i< element;i++) 
            {
                sol.Add(new DesignSol());                        
            }

        }

        
    }
}
