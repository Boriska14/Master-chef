using ConsoleApp1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalleCode.Model
{
    public class GroupeClientsFactory
    {
        private static GroupeClients GROUPE_CLIENTS = new GroupeClients(0);

        public static GroupeClients createGroupeClients(int nbreClients) {
            GROUPE_CLIENTS.nbreClients = nbreClients;

            Random rnd = new Random();
            int spriteIndex = rnd.Next(0, GroupeClients.sprites.Count);

            GROUPE_CLIENTS.sprite = GroupeClients.sprites[spriteIndex];

            return GROUPE_CLIENTS;
        }

    }
}
