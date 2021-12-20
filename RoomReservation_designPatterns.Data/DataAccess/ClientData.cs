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
           new Client(" belahrach","+212602052832","said.belahrach@usmba.ac.ma"),
           new Client("said ","+212602052832","said.belahrach@usmba.ac.ma"),
        };
    }
}
