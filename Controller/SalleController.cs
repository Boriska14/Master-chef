using ConsoleApp1.Model;
using ConsoleApp1.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Controller
{
    internal class SalleController
    {
        public Salle salle;
        public SalleView salleView;
         
       public static Queue<GroupeClients> clients = new Queue<GroupeClients>();
        public static ManualResetEvent clientsMre = new ManualResetEvent(false);
        public static ManualResetEvent commandeMre = new ManualResetEvent(false);
        public static ManualResetEvent cmdgroupMre = new ManualResetEvent(false); 
       

        public static Mutex clientsMutex = new Mutex(); 
        public static Mutex commandeMutex = new Mutex();    
        public static Queue<List<String>> commandes = new Queue<List<String>>();
        public static List<Table> tables = new List<Table>();
        public static Queue<Table> tablesOccupe = new Queue<Table>();


        ClientController clientController = new ClientController();
        MHController mhController = new MHController();
        CRController crController = new CRController(); 
        public static List<String> Menu = new List<String> { "Feuilleté au crabe", "Oeufs cocotte", "brouillinade", "vboles de picoulats", "Blanquette de veau" };
        public SalleController() 
        {
            this.salle = new Salle();
            this.salleView = new SalleView(salle);

        Table tablecouple2 = new Table(2);
                tables.Add(tablecouple2);
            Table tablecouple1 = new Table(2);
                    tables.Add(tablecouple1);
            Table table = new Table(4);
                    tables.Add(table);
            Table tableronde = new Table(6);
            tables.Add(tableronde);
        }

        public void run()
        {
            clientController.run(); 
            mhController.run();
            crController.run();
            salleView.run();
            salleView.run();
        }
    }
}
