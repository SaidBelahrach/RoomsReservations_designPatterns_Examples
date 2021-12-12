namespace RoomReservation_designPatterns.Data.DataModels
{
    public interface CreditCard : IPayment
    {

        public bool pay(double amount);
    }
}
