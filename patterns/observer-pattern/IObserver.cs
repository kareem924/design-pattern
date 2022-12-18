namespace observer_pattern
{
    internal interface IObserver
    {
        public void Update(ISubject subject);
    }
}
