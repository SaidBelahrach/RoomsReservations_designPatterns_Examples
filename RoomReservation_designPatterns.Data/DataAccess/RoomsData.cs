using RoomReservation_designPatterns.Data.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoomReservation_designPatterns.Data.DataAccess
{
    public class RoomsData
    {
        public static List<Room> allRooms = new List<Room>() {
            new Room(1,2,100),
            new Room(2,2,100),
            new Room(3,2,100),
            new Room(5,2,100),
            new Room(1,3,80),
            new Room(2,3,80),
            new Room(3,3,80),
            new Room(5,3,80),
        };
    }
}
