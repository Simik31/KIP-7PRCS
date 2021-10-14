using System.Collections.Generic;

namespace Dedicnost
{
    abstract class IntQueue
    {
        protected List<int> inner = new List<int>();

        public abstract void Push(int value);

        public int Pull()
        {
            int ret = 0;
            if (!IsEmpty())
            {
                ret = inner[0];
                inner.RemoveAt(0);
            }
            return ret;
        }

        public bool IsEmpty()
        {
            return inner.Count == 0;
        }
    }
}
