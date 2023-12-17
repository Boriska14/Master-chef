using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.View
{
    internal class SalleView
    {
        public Salle salle;
        public Frame frame;
        public SalleView(Salle salle)
        {
            this.salle = salle;
            this.frame = new Frame(salle);

        }

        public void run()
        {
            Application.Run(frame);
        }

    }
}
