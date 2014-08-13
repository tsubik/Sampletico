using Sampletico.Data.Common;
using Sampletico.Data.Factories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampletico.Data
{
    class Program
    {
        private static string connectionString;

        static void Main(string[] args)
        {
            bool migrations = args.Any(i => i.Equals("/migrations", StringComparison.InvariantCultureIgnoreCase));
            bool baseline = args.Any(i => i.Equals("/baseline", StringComparison.InvariantCultureIgnoreCase));
            connectionString = ConfigurationManager.ConnectionStrings["Simple.Data.Properties.Settings.DefaultConnectionString"].ConnectionString;

            if (migrations)
            {
                RunMigrations();
            }
            else if (baseline)
            {
                Baseline();
                GenerateSampleData();
            }
            else
            {
                GenerateSampleData();
            }
        }

        private static void GenerateSampleData()
        {
            Console.WriteLine("Generating data....");
            UserFactory.Generate();
            Console.WriteLine("Generating data - DONE");
        }

        private static void Baseline()
        {
            Console.WriteLine("Running baseline - applying migrations data....");
            Migrator.InitMigrationDbStructure(connectionString);
            Console.WriteLine("Running baseline - applying migrations data - DONE");
        }

        private static void RunMigrations()
        {
            Console.WriteLine("Running migrations....");
            Migrator.MigrateToNewestVersion(connectionString);
            Console.WriteLine("Running migrations - DONE");
        }
    }
}
