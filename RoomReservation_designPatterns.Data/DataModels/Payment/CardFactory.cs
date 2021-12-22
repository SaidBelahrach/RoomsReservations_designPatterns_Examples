namespace RoomReservation_designPatterns.Data.DataModels
{
    public class CardFactory
    {
        public CreditCard getCard(string type)
        {
            switch (type)
            {
                case "Visa":return new VisaCard(); 
                case "MasterCard": return new MasterCard();
                //... add other types
                default: return null;
            } 
        }

    }
}
