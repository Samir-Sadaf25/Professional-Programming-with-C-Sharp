using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable_Enumerator
{
    public class KeyEnumerator : IEnumerator<Key>
    {
        private Key[] _keys;
        private int _index;

        public KeyEnumerator(Key[] keys)
        {
           _keys = keys;
            _index = -1;
        }
        public Key Current => _keys[_index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            
        }

        public bool MoveNext()
        {
            _index++;
            if(_index < _keys.Length)
                return true;
            else return false;
        }

        public void Reset()
        {
            _index = -1;
        }
    }
}
