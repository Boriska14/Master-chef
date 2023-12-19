using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Model;
using ConsoleApp1.View;
using SalleCode.Model;

namespace ConsoleApp1.Controller
{
    public class ClientController
    {
        private Salle salle;
        public ClientController(Salle salle) {
            this.salle = salle;
        }
     
        public void addClient()
        {
            while (true)
            {
                Random rnd = new Random();
                int tmp  = rnd.Next(1000,10000);
                int nbreClients = rnd.Next(1, 7);
                Thread.Sleep(tmp);
                GroupeClients client = GroupeClientsFactory.createGroupeClients(nbreClients);
                SalleController.clientsMutex.WaitOne();
                SalleController.clients.Enqueue(client);
                salle.clients.Add(client);
                Salle.notifyObserver(client.x, client.y, client.x, client.y, client.sprite.Width, client.sprite.Height);
                SalleController.clientsMutex.ReleaseMutex();
                Thread clientthread = new Thread(() => { order(nbreClients); });
                clientthread.Start();
                Console.WriteLine(nbreClients + " nouveaux clients");
                SalleController.clientsMre.Set();

            }
        }

        public void order(int nbreClients)
        {
            SalleController.cmdgroupMre.WaitOne();
            SalleController.cmdgroupMre.Reset();
            List<string> cmde = new List<string>();
            Random aleatoire = new Random();
            while (cmde.Count < nbreClients)
            {
                String cmd = SalleController.Menu[aleatoire.Next(SalleController.Menu.Count)];
                cmde.Add(cmd);
            }

            Thread.Sleep(5000);

            Console.WriteLine("Clients : nous avons fait notre choix");
            SalleController.commandeMutex.WaitOne();
            SalleController.commandes.Enqueue(cmde);
            SalleController.commandeMutex.ReleaseMutex();


            foreach (String pool in cmde)
            {
                Console.WriteLine(pool);

            }
            SalleController.commandeMre.Set();
               
        }

        public void moveToTable()
        {
            while(true) 
            {
                SalleController.clientsMoveToTableMre.WaitOne();
                SalleController.clientsMoveToTableMre.Reset();

                Table table = SalleController.tablesOccupe.Peek();
               //SalleController.clients.moveTO(table.x, table.y);
            }
        }

        public void run()
        {
            Thread threadClient = new Thread(addClient);
            threadClient.Start();
            Thread threadMoveClient = new Thread(moveToTable);
            threadMoveClient.Start();
        }

    }
}
