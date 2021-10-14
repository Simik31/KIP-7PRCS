namespace Dedicnost
{
    class UniqueIntQueue : IntQueue
    {
        public override void Push(int value)
        {
            if(!inner.Contains(value)) inner.Add(value);
        }
    }
}
