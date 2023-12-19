using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Model;
using SalleCode.Model;

namespace ConsoleApp1.Controller
{
    internal class MHController
    {
        private Salle salle;

        public MHController(Salle salle)
        {
            this.salle = salle;
        }

        public void Send()

        {
            while (true) 
            {
           
                SalleController.clientsMre.WaitOne();

  
               // if (SalleController.clients.Count == 0) { return; }
                Console.WriteLine("Maitre d'hotel : le client a bien été recu");
                SalleController.clientsMre.Reset();

                SalleController.clientsMutex.WaitOne();
                GroupeClients clients = SalleController.clients.Peek();
                SalleController.clientsMutex.ReleaseMutex();
                int nbreClients = clients.nbreClients;
                Table tableTrouvee = null;

                foreach ( Table table  in salle.tables) 
                {
                    if (table.nbre_place >= nbreClients && !SalleController.tablesOccupe.Contains(table)) 
                    {
                        tableTrouvee = table;                
                        break;
                    }

                }
                

                if (tableTrouvee != null)
                {
                    SalleController.tablesOccupe.Enqueue(tableTrouvee);
                    SalleController.clientsMoveToTableMre.Set();
                    salle.mh.moveTo(tableTrouvee.x, tableTrouvee.y);
                    Console.WriteLine("Maitre d'hotel:le client est bien installé");
                    SalleController.cmdgroupMre.Set();
                    salle.mh.moveTo(50, 0);
                }
                else
                {
                    Console.WriteLine("Maitre d'hotel : il n'ya aucune table disponible");
                }
                
                SalleController.clients.Dequeue();

            }
        }

        public void run()
        {
            Thread threadMaitreHotel = new Thread(Send);
            threadMaitreHotel.Start();
        }
    }
       
       
    
}
