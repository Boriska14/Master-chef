using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class DesignSol
    {
        public Image sprite { get; set; }

        public DesignSol()
        {
            this.sprite = Image.FromFile("C:\\Users\\lonovo\\source\\repos\\ConsoleApp1\\assets\\carrelage.png");
        }
    }
}
