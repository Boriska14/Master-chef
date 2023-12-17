using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Model;

namespace ConsoleApp1.Controller
{
    internal class MHController
    {
        public void Send()

        {
            while (true) 
            {
           
                SalleController.clientsMre.WaitOne();

  
               // if (SalleController.clients.Count == 0) { return; }
                Console.WriteLine("Maitre d'hotel : le client a bien été recu");
                SalleController.clientsMre.Reset();

                SalleController.clientsMutex.WaitOne();
                GroupeClients clients = SalleController.clients.Dequeue();
                SalleController.clientsMutex.ReleaseMutex();
                int nbreClients = clients.nbreClients;
                bool tableTrouvee = false;

                foreach ( Table table  in SalleController.tables) 
                {
                    if (table.nbre_place >= nbreClients && !SalleController.tablesOccupe.Contains(table)) 
                    {
                        tableTrouvee = true;                
                        SalleController.tablesOccupe.Enqueue(table);
                        break;
                    }

                }
                

                if (tableTrouvee)
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("Maitre d'hotel:le client est bien installé");
                    SalleController.cmdgroupMre.Set();
                }

                else
                {
                    Console.WriteLine("Maitre d'hotel : il n'ya aucune table disponible");
                }
               

            }
        }

        public void run()
        {
            Thread threadMaitreHotel = new Thread(Send);
            threadMaitreHotel.Start();
        }
    }
       
       
    
}
