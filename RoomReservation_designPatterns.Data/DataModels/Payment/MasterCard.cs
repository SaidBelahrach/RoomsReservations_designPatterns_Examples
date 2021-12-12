namespace RoomReservation_designPatterns.Data.DataModels
{
    public class MasterCard : CreditCard
    {

        public bool pay(double amount)
        {
            System.Console.WriteLine("Payement with MasterCard\nAmount to pay: " + amount);
            return false;
        }
    }
}
