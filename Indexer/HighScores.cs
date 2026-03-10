using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
     public class HighScores
    {
        private Dictionary<string,int> scores = new Dictionary<string,int>();
        public int this[string name]
        {
            get { return scores.ContainsKey(name) ? scores[name] : 0; }
            set { scores[name] = value; }
        }
        public int this[int id]
        {
            get { return scores[id.ToString()]; }
            set { scores[id.ToString()] = value; }
        }
    }
}
