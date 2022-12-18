namespace observer_pattern
{
    internal class Subject : ISubject
    {
        public int State { get; set; } = -0;

        private List<IObserver> _observers = new List<IObserver>();


        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var item in _observers)
            {
                item.Update(this);
            }
        }

        public void SomeBusinessLogic()
        {
            this.State = 5;

            Thread.Sleep(15);

            this.Notify();
        }
    }
}
