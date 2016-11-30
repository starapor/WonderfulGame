using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace WonderfulGame.Better
{
    public class Matcher<T> : IEnumerable<KeyValuePair<Predicate<T>, Action>>
    {
        private readonly IDictionary<Predicate<T>, Action> _matcher = new Dictionary<Predicate<T>, Action>();

        public void DoActionThatMatches(T t)
        {
            _matcher.First(m => m.Key(t)).Value();
        }

        public IEnumerator<KeyValuePair<Predicate<T>, Action>> GetEnumerator()
        {
            return _matcher.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Predicate<T> predicate, Action action)
        {
            _matcher.Add(predicate, action);
        }
    }
}