using System.Collections.Generic;
using System;

namespace Colombus.Utils
{
    public class WeightenedRandomBag<T>
    {
        private class Entry
        {
            public double _accumulateWeight;
            public T _object;
        }

        private List<Entry> _entryList = new List<Entry>();
        private double _accumulatedWeight;
        private Random rand = new Random();

        public void AddEntry(T _object, double _weight)
        {
            _accumulatedWeight += _weight;
            Entry e = new Entry();
            e._accumulateWeight = _accumulatedWeight;
            e._object = _object;
            _entryList.Add(e);
        }

        public T GetRandom()
        {
            double r = rand.NextDouble() * _accumulatedWeight;
            foreach (Entry e in _entryList)
            {
                if (e._accumulateWeight >= r)
                {
                    return e._object;
                }
            }
            return default(T);
        }
    }
}