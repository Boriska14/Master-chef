using SalleCode.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Composition;

namespace ConsoleApp1.Model
{
    public class MaitreHotel : MobileElement
    {
        private readonly static Image SPRITE = Image.FromFile("C:\\Users\\lonovo\\source\\repos\\ConsoleApp1\\assets\\MH.png");
        public MaitreHotel() : base(SPRITE)
        {
            this.x = 50;
            this.y = 0;
        }
    }
}
