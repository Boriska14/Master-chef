using ConsoleApp1.Controller;
using SalleCode.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class GroupeClients : MobileElement
    {

        public int nbreClients { get; set; }
        public static List<Image> sprites = new List<Image>
        {
            Image.FromFile("C:\\Users\\lonovo\\source\\repos\\ConsoleApp1\\assets\\Client1.png"),
            Image.FromFile("C:\\Users\\lonovo\\source\\repos\\ConsoleApp1\\assets\\Client2.png")
        };   
        public GroupeClients(int nbreClients) : base(sprites[0])
        {
            this.nbreClients = nbreClients;            
        }
    }
}
