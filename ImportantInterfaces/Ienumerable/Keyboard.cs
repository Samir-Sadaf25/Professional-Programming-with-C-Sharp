using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerable_Enumerator
{
    public class Keyboard : IEnumerable<Key>
    {
        private Key[] _keys = [new Key { Name = "A", Code = 65 }, new Key { Name = "B", Code = 66 }];
       

        public IEnumerator<Key> GetEnumerator()
        {
            return new KeyEnumerator(_keys);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           
            return GetEnumerator();
        }
    }
}
