using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalleCode.Model
{
    internal class Table6P1:Table
    {
        private readonly static Image SPRITE = Image.FromFile("C:\\Users\\lonovo\\source\\repos\\ConsoleApp1\\assets\\Table6.png");
        public Table6P1(int x, int y) : base(SPRITE, 6)
        {
            this.x = x;
            this.y = y;
        }
    }
}
