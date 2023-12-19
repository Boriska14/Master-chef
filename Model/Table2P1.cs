using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SalleCode.Model
{
    public class Table2P1 : Table
    {
        private readonly static Image SPRITE = Image.FromFile("C:\\Users\\lonovo\\source\\repos\\ConsoleApp1\\assets\\Table2.png");
        public Table2P1(int x ,int y) : base(SPRITE, 2)
        {
            this.x = x;
            this.y = y;
        }
    }
}
