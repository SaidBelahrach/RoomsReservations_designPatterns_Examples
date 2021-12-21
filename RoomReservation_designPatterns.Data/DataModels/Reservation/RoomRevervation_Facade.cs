using System;
using System.Collections.Generic;

namespace RoomReservation_designPatterns.Data.DataModels
{
    public class RoomRevervation_Facade
    {
        public Hotel hotel { get; set; }
        public Reservation reservation { get; set; }
        public Payment_Stategy payment_Stategy { get; set; }


        public RoomRevervation_Facade()
        {
           
        }

        public RoomRevervation_Facade(Reservation reservation, Payment_Stategy payment_Stategy, Hotel hotel)
        {
            this.reservation = reservation;
            this.payment_Stategy = payment_Stategy;
            this.hotel = hotel;
        }


        public List<Room> getAvailableRooms(DateTime d1, DateTime d2)
        {
            if(hotel == null)
            {
                this.hotel =  Hotel.GetInstance();
            }
            return hotel.getAvailableRooms(d1, d2);
        }

        public void addReservation(Reservation res)
        {
            if (hotel == null)
            {
                this.hotel = Hotel.GetInstance();
            }
            this.hotel.addReservation(res);
        }
        public bool payReservation()
        {
            reservation.book();
            payment_Stategy.pay(reservation.amount);
            return true;
        }

        public bool cancel()
        {
            reservation.cancel();
            return true;
        } 
    }
}
