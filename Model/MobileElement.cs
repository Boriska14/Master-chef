using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalleCode.Model
{
    public class MobileElement : Element
    {
        public readonly static int SPEED = 10;
        public MobileElement(Image sprite):base(sprite) { 
        }

        public void moveTo(int x, int y)
        {
            while (this.x != x || this.y != y)
            {
                int previousX = this.x;
                int previousY = this.y;

                if (this.x < x)
                {
                    this.x += SPEED;
                }
                else
                {
                    this.x -= SPEED;
                }

                if (this.y < y)
                {
                    this.y += SPEED;
                }
                else
                {
                    this.y -= SPEED;
                }

                Salle.notifyObserver(previousX, previousY, this.x, this.y, this.sprite.Width, this.sprite.Height);

                Thread.Sleep(10);
            }
        }
    }
}
