namespace RoomReservation_designPatterns.Data.DataModels
{
    public class VisaCard : CreditCard
    {

        public bool pay(double amount)
        {
            System.Console.WriteLine("Payement with VisaCard\nAmount to pay: " + amount);
            return false;
        }
    }
}
