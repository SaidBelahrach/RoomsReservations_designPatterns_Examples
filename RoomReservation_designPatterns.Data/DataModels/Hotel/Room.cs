using System;
using System.Linq;

namespace RoomReservation_designPatterns.Data.DataModels
{
    public class Room
    {
        public int number { get; set; }
        public int floor { get; set; }
        public float price { get; set; }

        public Room(int number, int floor, float price)
        {
            this.number = number;
            this.floor = floor;
            this.price = price;
        }

        public bool isAvailable(DateTime d1,DateTime d2) {
           return Hotel.GetInstance().reservations
                .Where(r => r.room.number == number && ((d1> r.dateDebut && d1 <r.dateFin) || (d2 > r.dateDebut && d2 < r.dateFin)))
                .Any();
        }
    } 
}
