using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Membership
    {
        public User CreateUser(string username, string password)
        {
            IdGenerator generator = new IdGenerator();
            EncryptionUtility encryption = new EncryptionUtility();

            User user = new User();
            user.Id = generator.GenerateId(username);
            user.Username = username;
            user.Password = encryption.EncryptedText(password);
        }
    }
}
