using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    public class Person
    {
        private readonly string _id = string.Empty;
        private const string _securityCode = "ABCD";

        public Person(string id)
        {
            _id = id;
            // _securityCode = "abcde"; // Can't do it with const
        }

        public void ChangeId(string id)
        {
            //_id = id; // Cannot do it with readonly
        }
    }
}