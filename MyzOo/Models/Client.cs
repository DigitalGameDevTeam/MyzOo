using MyzOo.Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyzOo.Models
{
    internal class Client
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public Client(string username, string password)
        {
            this.Username = username;
            this.Password = password;
        }

        // Encrypts string via sha512(blake2b) hash function
        public static string encryptSHA512(string input)
        {
            HashAlgorithm ha = SHA512.Create();
            StringBuilder sb = new StringBuilder();

            byte[] hashDigest = ha.ComputeHash(Encoding.UTF8.GetBytes(input));

            for (int i = 0; i < hashDigest.Length; i++)
                sb.Append(hashDigest[i].ToString("x2"));

            return sb.ToString();
        }
    }
}
