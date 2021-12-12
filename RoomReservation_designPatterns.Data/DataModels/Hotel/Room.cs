namespace RoomReservation_designPatterns.Data.DataModels
{
    public class Room: IObservable
    {
        public bool state { get; set; } 
        public IObserver observer { get; set; }

        public void Attach(IObserver observer)
        {
            this.observer = observer;
        }

        public void Detach()
        {
            this.observer = null;
        }

        public void Notify()
        {
            throw new System.NotImplementedException();
        }
    }
    public interface IObserver
    {
        void Update(IObservable subject, string action);
    }

    public interface IObservable
    {
        void Attach(IObserver observer);

        void Detach();

        void Notify();
    }
}
