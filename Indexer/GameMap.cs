using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class GameMap
    {
        private string[,] forest = new string[5, 5];
        public string this[int x, int y]
        {
            get { return forest[x,y]; }
            set { forest[x,y] = value; }
        
        }
    }
}
