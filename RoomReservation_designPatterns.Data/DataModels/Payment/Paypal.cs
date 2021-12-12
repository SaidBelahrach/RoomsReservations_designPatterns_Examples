namespace RoomReservation_designPatterns.Data.DataModels
{
    public class Paypal: IPayment
    {
        public string email { get; set; }
        public string password { get; set; }

        public bool pay(double amount)
        {
            System.Console.WriteLine("Payement with Paypal\nAmount to pay: "+amount);
            return false;
        }
    }
}
