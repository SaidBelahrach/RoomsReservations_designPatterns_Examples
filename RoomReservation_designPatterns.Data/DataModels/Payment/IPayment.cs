using System;
using System.Collections.Generic;
using System.Text;

namespace RoomReservation_designPatterns.Data.DataModels
{
    public interface IPayment
    {

        public bool pay(double amount);
    }
}
