using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalleCode.Model
{
    internal class Table8P1:Table
    {
        private readonly static Image SPRITE = Image.FromFile("C:\\Users\\lonovo\\source\\repos\\ConsoleApp1\\assets\\Table8.png");

        public Table8P1(int x, int y) : base(SPRITE, 8)
        {
            this.x = x;
            this.y = y;
        }
    }
}
