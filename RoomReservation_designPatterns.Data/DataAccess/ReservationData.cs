using RoomReservation_designPatterns.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoomReservation_designPatterns.Data.DataAccess
{
    public class ReservationData
    {
        public static List<Reservation> reservations = new List<Reservation>() {
           new Reservation(new Room(1,1,100.00f),DateTime.Now.AddDays(2),DateTime.Now.AddDays(5)),
           new Reservation(new Room(2,1,50.00f),DateTime.Now.AddDays(10),DateTime.Now.AddDays(21)),
           new Reservation(new Room(3,1,250.00f),DateTime.Now.AddDays(4),DateTime.Now.AddDays(15)),
        };
    }
}
