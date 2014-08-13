using Simple.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;

namespace Sampletico.Core.Entities
{
    public class User : Entity
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PasswordSalt { get; set; }
        public bool IsAdmin { get; set; }
    }
}