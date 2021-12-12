using System;
using System.Collections.Generic;
using System.Text;

namespace RoomReservation_designPatterns.Data.DataModels
{
    public class Client
    {
        public string id { get; set; }
        public string fullname { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public Client(string fullname, string phone, string email)
        {
            this.fullname = fullname;
            this.phone = phone;
            this.email = email;
        }
    }
}
