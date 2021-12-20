using RoomReservation_designPatterns.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoomReservation_designPatterns.Data.DataAccess
{
    public class ClientData
    {
        public static List<Client> allClients = new List<Client>() {
           new Client("said belahrach","+212602052832","said.belahrach@usmba.ac.ma"),
           new Client("Mohamed messlohi","+212602052832","Mohamed.messlohi@usmba.ac.ma"),
           new Client("Saad mn fes","+212602052832","Saad.Saad@usmba.ac.ma"),
        };
    }
}
