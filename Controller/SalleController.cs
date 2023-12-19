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
        public static ManualResetEvent clientsMoveToTableMre = new ManualResetEvent(false);
        public static ManualResetEvent commandeMre = new ManualResetEvent(false);
        public static ManualResetEvent cmdgroupMre = new ManualResetEvent(false); 
       

        public static Mutex clientsMutex = new Mutex(); 
        public static Mutex commandeMutex = new Mutex();    
        public static Queue<List<String>> commandes = new Queue<List<String>>();
        public static List<Table> tables = new List<Table>();
        public static Queue<Table> tablesOccupe = new Queue<Table>();


        ClientController clientController;
        MHController mhController;
        CRController crController;
        public static List<String> Menu = new List<String> { "Feuilleté au crabe", "Oeufs cocotte", "brouillinade", "vboles de picoulats", "Blanquette de veau" };
        public SalleController() 
        {
            this.salle = new Salle();
            this.salleView = new SalleView(salle);
            this.salle.addObserver(salleView);
            this.clientController = new ClientController(this.salle);
            this.mhController = new MHController(this.salle);
            this.crController = new CRController();
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
