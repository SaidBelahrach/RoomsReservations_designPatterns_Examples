using System;

namespace RoomReservation_designPatterns.Data.DataModels
{
    public class Reservation
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public double amount { get; set; }
        public string status { get; set; }

        Client client;
        Room room;

        public Reservation(Client client, Room room, double amount)
        {
            this.client = client;
            this.room = room;
            this.date = DateTime.Now;
            this.amount = amount;
            this.status= "created";
        }
        public bool book()
        { 
            this.status = "payed";
            return false;
        }
        public bool cancel()
        {
            return false;
        }
        public bool getStatus()
        {
            return false;
        }
    }
}
