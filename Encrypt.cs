using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BaumanBooking
{
    class Encrypt
    {
        public static string HashString(string password)
        {
            StringBuilder sb = new StringBuilder();
            foreach (byte _byte in GetHash(password))
                sb.Append(_byte.ToString("X3"));
            return sb.ToString();
        }

        public static byte[] GetHash(string password)
        {
            using (HashAlgorithm algorithm = SHA256.Create())
                return algorithm.ComputeHash(Encoding.UTF8.GetBytes(password));
        }
    }
}
