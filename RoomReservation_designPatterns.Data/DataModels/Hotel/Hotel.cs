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
        public Client CurrentClient { get; set; }
        public List<Reservation> reservations { get; set; }

        private static Hotel hotel= null;

        private Hotel()
        { 
            clients = DataAccess.ClientData.allClients; //default values
            rooms = DataAccess.RoomsData.allRooms;      //default values
            reservations = new List<Reservation>();
        }

        public static Hotel GetInstance()
        {
            if (hotel == null)
            {
                hotel = new Hotel(); 
            }
            return hotel;
        }

        public List<Room> getAvailableRooms(DateTime dateDebut, DateTime dateFin)
        {
            return rooms.Where(r => r.isAvailable(dateDebut,dateFin)).ToList(); 
        } 

        public Room getFirstEmptyAvailbaleRoom(DateTime dateDebut, DateTime dateFin)
        {
            return rooms.Where(r => r.isAvailable(dateDebut, dateFin)).FirstOrDefault();
        }

        public void addReservation(Reservation res)
        {
            this.reservations.Add(res);
        }
    }
}
