namespace Dedicnost
{
    class SimpleIntQueue : IntQueue
    {
        public override void Push(int value)
        {
            inner.Add(value);
        }
    }
}
