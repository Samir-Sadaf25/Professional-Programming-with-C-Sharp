using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class SimpleCollection
    {
       private string[] words = new string[5];
        public string this[int i]
        {
            get { return words[i]; }
            set { words[i] = value; }
        }
    }
}
