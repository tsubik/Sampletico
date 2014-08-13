using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sampletico.Core.Entities;
using Sampletico.Core.Services;

namespace Sampletico.Data.Factories
{
    public static class UserFactory
    {
        public static User Admin { get; private set; }
        public static void Generate()
        {
            Console.WriteLine("-----Generating users-------");
            Admin = UserService.RegisterUser("admin@sampletico.fake.com", "qwe123", true);
            Console.WriteLine("-----Generating users ends-------");
        }

    }
}
