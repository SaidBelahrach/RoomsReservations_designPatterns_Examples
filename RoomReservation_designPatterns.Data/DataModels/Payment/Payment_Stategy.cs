namespace RoomReservation_designPatterns.Data.DataModels
{
    public class Payment_Stategy
    {
        public IPayment paymentMethod { get; set; } 

        public Payment_Stategy(IPayment paymentMethod) //for credit card Payment_Stategy( new CardFactory().getCard("Visa") )
        {
            this.paymentMethod = paymentMethod;
        }

        public bool pay(double amount)
        {
            paymentMethod.pay(amount);
            return  true;
        }

    }
}
