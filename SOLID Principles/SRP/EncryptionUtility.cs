using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class EncryptionUtility
    {
        public string EncryptedText(string plainPassword)
        {
            return MD5.Create(plainPassword).ToString();
        }
    }
}
