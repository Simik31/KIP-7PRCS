using System;
using System.Collections.Generic;
using System.Linq;

namespace Bag
{
    class List
    {
        private readonly List<int> numbers;

        public delegate void ListAddDelegate(List sender);
        public event ListAddDelegate ListAdd;

        public List()
        {
            numbers = new List<int>();
            MonitorList(this);
        }

        public void Add(int value)
        {
            numbers.Add(value);
            if (ListAdd != null) ListAdd(this);
        }

        internal void MonitorList(List sender)
        {
            sender.ListAdd += ListAdded;
        }

        private void ListAdded(List sender)
        {
            Console.WriteLine($"Added number {sender.numbers.Last()}; Curent size: {sender.numbers.Count}");
        }
    }
}
