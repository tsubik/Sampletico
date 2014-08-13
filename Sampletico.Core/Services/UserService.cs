using Sampletico.Core.Entities;
using Simple.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sampletico.Core.Services
{
    public class UserService
    {
        public static User RegisterUser(string email, string password, bool isAdmin=false)
        {
            User user = new User
            {
                Email = email
            };
            user.PasswordSalt = CreateSalt();
            user.Password = HashPassword(password, user.PasswordSalt);
            user.IsAdmin = isAdmin;
            user = Database.Open().Users.Insert(user);
            
            return user;
        }

        public static User FindByEmail(string email)
        {
            return Database.Open().Users.FindAllByEmail(email).FirstOrDefault();
        }

        public static User FindById(int id)
        {
            return Database.Open().Users.FindById(id);
        }

        public static IList<User> GetAll()
        {
            return Database.Open().Users.All().ToList<User>();
        }

        public static dynamic Query()
        {
            return Database.Open().Users;
        }

        public static User Authenticate(string email, string password)
        {
            var user = FindByEmail(email);
            if (user != null)
            {
                if (user.Password == HashPassword(password, user.PasswordSalt))
                {
                    return user;
                }
            }
            return null;
        }

        private static string CreateSalt()
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[128];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        private static string HashPassword(string password, string salt)
        {
            var toHash = password + salt;

            HashAlgorithm hashAlg = new SHA256CryptoServiceProvider();
            byte[] toHashBytes = System.Text.Encoding.UTF8.GetBytes(toHash);
            byte[] hashedBytes = hashAlg.ComputeHash(toHashBytes);

            return Convert.ToBase64String(hashedBytes);
        }
    }
}
