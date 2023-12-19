using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.View
{
    public class SalleView
    {
        public Salle salle;
        public Frame frame;
        public SalleView(Salle salle)
        {
            this.salle = salle;
            this.frame = new Frame(salle);
        }

        public void update(int previousX, int previousY, int x, int y, int width, int height)
        {
            this.frame.Invalidate(new Rectangle(previousX, previousY, width, height));

            this.frame.Invalidate(new Rectangle(x, y, width, height));

            if (this.frame.InvokeRequired)
            {
                this.frame.Invoke(new Action(() =>
                {
                    this.frame.Update();
                }));
            }
            else
            {
                this.frame.Update();
            }

        }

        public void run()
        {
            Application.Run(frame);
        }

    }
}

