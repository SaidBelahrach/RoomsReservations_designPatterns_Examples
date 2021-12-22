using System;
using System.Collections.Generic;
using System.Linq;

namespace RoomReservation_designPatterns.Data.DataModels
{
    public class Reservation
    {
        public int id { get; set; }
        public DateTime dateDebut { get; set; }
        public DateTime dateFin { get; set; }
        public float amount { get; set; }
        public string status { get; set; }
        public Client client { get; set; }
        public Room room { get; set; } 
        public Hotel hotel= Hotel.GetInstance();
        public Reservation( Room room, DateTime dateDebut, DateTime dateFin)
        {
            this.client = Hotel.GetInstance().CurrentClient;
            this.room = room;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;  
            this.amount =(float) dateFin.Subtract(dateDebut).TotalDays * room.price;
            this.status= "Created"; 
        }
        public bool book()
        { 
            this.status = "Booked"; 
            return true;
        }
        public bool cancel()
        {
            this.status = "Canceled";
            Console.WriteLine("Reservation canceled");
            Hotel.GetInstance().reservations.Remove(this);
            return false;
        }
        public string getStatus()
        {
            return this.status;
        }

        public float getReservationPrice()
        {
            return this.room.price * ((this.dateFin - this.dateFin).Days +1);
        }

    }
}
