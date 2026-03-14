using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class IdGenerator
    {
        public string GenerateId(string username)
        {
            Random random = new Random(DateTime.Now.Microsecond);
            return char.ToUpper(username[0]).ToString() + random.Next();
        }
    }
}
