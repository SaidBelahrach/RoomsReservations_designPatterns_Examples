using System;

namespace RoomReservation_designPatterns.Data.DataModels
{
    public class Reservation
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public double amount { get; set; }
        public string status { get; set; }
        public Client client { get; set; }
        public Room room { get; set; }

        public Reservation(Client client, Room room, double amount)
        {
            this.client = client;
            this.room = room;
            this.date = DateTime.Now;
            this.amount = amount;
            this.status= "Created";
        }
        public bool book()
        { 
            this.status = "Booked";
            Console.WriteLine("Reservation Booked");
            return false;
        }
        public bool cancel()
        {
            this.status = "Canceled";
            Console.WriteLine("Reservation canceled");
            return false;
        }
        public string getStatus()
        {
            return this.status;
        }
    }
}
