using ConsoleApp1.View;
using SalleCode.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class Salle
    {
        public int width {get; set;}
        public int height { get; set;}
        public List<DesignSol> sol { get; set; }
        public List<Table> tables { get; set; }

        public List<GroupeClients> clients { get; set; }
        private static SalleView observer;
        public MaitreHotel mh { get; set; }

        public Salle()
        { 
            this.clients = new List<GroupeClients>();
            this.mh = new MaitreHotel();
            width = 880; 
            height = 660;
            
            sol = new List<DesignSol>();
            int nbre_width = width / 80;
            int nbre_height = height / 60;
            int  element = nbre_width * nbre_height;

            for  (int i = 0; i< element;i++) 
            {
                sol.Add(new DesignSol());                        
            }

            this.tables = new List<Table>();

            Table2P1 table2Places = new Table2P1(30,80);
            tables.Add(table2Places);
            Table4P1 table4Places = new Table4P1(30,200); 
            tables.Add(table4Places);
            Table2P1 table2Place = new Table2P1(30, 450);
            tables.Add(table2Place);
            Table4P1 table4Place = new Table4P1(250, 80);
            tables.Add(table4Place);
            Table2P1 table2P = new Table2P1(250, 300);
            tables.Add(table2P);
            Table4P1 table4P = new Table4P1(250, 400);
            tables.Add(table4P);

            Table8P1 table8P = new Table8P1(457, 30);
            tables.Add(table8P);
            Table8P1 table8Place = new Table8P1(457, 300);
            tables.Add(table8Place);
            Table6P1 table6 = new Table6P1(600, 150);
            tables.Add(table6);
            Table6P1 table6Place = new Table6P1(600, 430);
            tables.Add(table6Place);

        }

        public void addObserver(SalleView observer)
        {
            Salle.observer = observer;
        }

        public static void notifyObserver(int previousX, int previousY, int x, int y, int width, int height)
        {
            observer.update(previousX, previousY, x, y, width, height);
        }
    }
}
