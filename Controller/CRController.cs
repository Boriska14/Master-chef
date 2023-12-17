using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Controller
{
    internal class CRController
    {
        public void handleOrders()
        {

            while (true)
            {
                SalleController.commandeMre.WaitOne();
                SalleController.commandeMutex.WaitOne();
                if (SalleController.commandes.Count == 0) { continue; }
                List<String> commande = SalleController.commandes.Dequeue();
                SalleController.commandeMutex.ReleaseMutex();
                SalleController.commandeMre.Reset();
                Console.WriteLine("chef de rang: j'ai pris vos commandes");
            }
        }
        public void run()
        {
            Thread threadChefRang = new Thread(handleOrders);
            threadChefRang.Start();
            Thread threadChefRang2 = new Thread(handleOrders);
            threadChefRang2.Start();
        }






    }
}
