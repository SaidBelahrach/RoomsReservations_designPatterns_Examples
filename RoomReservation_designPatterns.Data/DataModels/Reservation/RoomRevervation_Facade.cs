using System.Collections.Generic;

namespace RoomReservation_designPatterns.Data.DataModels
{
    public class RoomRevervation_Facade
    {
        public Hotel hotel { get; set; }
        public Reservation reservation { get; set; }
        public Payment_Stategy payment_Stategy { get; set; }

        public RoomRevervation_Facade(Reservation reservation, Payment_Stategy payment_Stategy, Hotel hotel)
        {
            this.reservation = reservation;
            this.payment_Stategy = payment_Stategy;
            this.hotel = hotel;
        }

        public List<Room> getAvailableRooms()
        {
            hotel.getAvailableRooms();
            return null;
        }
        public bool book()
        {
            reservation.book();
            return true;
        }

        public bool cancel()
        {
            reservation.cancel();
            return true;
        }
        public bool pay()
        {
            payment_Stategy.pay(reservation.amount);
            return true;
        }

    }
}
