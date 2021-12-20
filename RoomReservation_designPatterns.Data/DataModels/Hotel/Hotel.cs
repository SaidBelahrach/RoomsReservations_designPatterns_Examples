using System;
using System.Collections.Generic;
using System.Linq;

namespace RoomReservation_designPatterns.Data.DataModels
{
    public class Hotel
    {
        public string name { get; set; }
        public List<Room> rooms { get; set; }
        public List<Client> clients { get; set; }

        private static Hotel hotel= null;

        private Hotel()
        { 
            clients = DataAccess.ClientData.allClients; //default values
            rooms = DataAccess.RoomsData.allRooms;      //default values
        }

        public static Hotel GetInstance()
        {
            if (hotel == null)
            {
                hotel = new Hotel(); 
            }
            return hotel;
        }

        public List<Room> getAvailableRooms()
        {
            // return rooms.Where(r => r.state.Equals("avai")).ToList();//to impl
            return rooms; 
        }

       
    }
}
