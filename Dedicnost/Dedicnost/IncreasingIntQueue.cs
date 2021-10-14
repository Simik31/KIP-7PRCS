namespace Dedicnost
{
    class IncreasingIntQueue : IntQueue
    {
        public override void Push(int value)
        {
            if (IsEmpty() || value > inner[^1]) inner.Add(value);
        }
    }
}
