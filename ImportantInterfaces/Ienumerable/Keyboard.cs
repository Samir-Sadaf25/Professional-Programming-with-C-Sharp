using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable_Enumerator
{
    public class Keyboard : ICollection<Key>
    {
        private Key[] _keys = new Key[200];
        private int idx = 0;

        public int Count => idx;

        public bool IsReadOnly => false;

        public void Add(Key item)
        {
            if (idx >= _keys.Length) throw new InvalidOperationException("Keyboard is full");
            _keys[idx++] = item;
        }

        public void Clear()
        {
            // Optional: clear references for GC
            Array.Clear(_keys, 0, idx);
            idx = 0;
        }

        public bool Contains(Key item)
        {
            // Use reference or value equality depending on Key semantics
            for (int i = 0; i < idx; i++)
            {
                if (_keys[i] == item)
                    return true;
            }
            return false;
        }

        public void CopyTo(Key[] array, int arrayIndex)
        {
            if (array == null) throw new ArgumentNullException(nameof(array));
            if (arrayIndex < 0) throw new ArgumentOutOfRangeException(nameof(arrayIndex));
            if (arrayIndex + Count > array.Length) throw new ArgumentException("Destination array is too small");

            Array.Copy(_keys, 0, array, arrayIndex, idx);
        }

        public IEnumerator<Key> GetEnumerator()
        {
            for (int i = 0; i < idx; i++)
                yield return _keys[i];
        }

        public bool Remove(Key item)
        {
            for (int i = 0; i < idx; i++)
            {
                if (EqualityComparer<Key>.Default.Equals(_keys[i], item))
                {
                    // shift left
                    int moveCount = idx - i - 1;
                    if (moveCount > 0) Array.Copy(_keys, i + 1, _keys, i, moveCount);
                    _keys[--idx] = null; // clear last slot for GC safety
                    return true;
                }
            }
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
