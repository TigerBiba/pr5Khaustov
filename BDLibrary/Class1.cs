using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BDLibrary
{
    public class Class1
    {
        public string HashPassword(string password)
        { 
            using (SHA256  sha256 = SHA256.Create())
            {
                byte[] sourceBytePassword = Encoding.UTF8.GetBytes(password);
                byte[] hashsourceBytePassword = sha256.ComputeHash(sourceBytePassword);
                string hashPassword = BitConverter.ToString(hashsourceBytePassword).Replace("-", String.Empty);
                return hashPassword;
            }
        }
    }
}
