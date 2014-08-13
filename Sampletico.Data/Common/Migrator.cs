using roundhouse;
using roundhouse.infrastructure.app;
using roundhouse.infrastructure.logging.custom;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sampletico.Data.Common
{
    public static class Migrator
    {
        public static string MIGRATION_PATH = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
            @"..\..\..\SampleticoDB");

        public static void MigrateToNewestVersion(string connectionString)
        {
            Migrate migrator = new Migrate().Set(c =>
            {
                c.Logger = new ConsoleLogger();
                c.ConnectionString = connectionString;
                c.SqlFilesDirectory = MIGRATION_PATH;
                c.SprocsFolderName = @"dbo\Stored Procedures";
                c.ViewsFolderName = @"dbo\Views";
                c.FunctionsFolderName = @"dbo\Functions";
                c.UpFolderName = @"Scripts\Migrations\up";
                c.RunBeforeUpFolderName = @"Scripts\Migrations\runbeforeup";
                c.RunFirstAfterUpFolderName = @"Scripts\Migrations\runfirstafterup";
                c.DownFolderName = @"Scripts\Migrations\down";
                c.Restore = false;
                c.Silent = true;
                c.WithTransaction = true;
                c.UsingVSDBProjectScripts = true;
            });

            var configuration = migrator.GetConfiguration();
            ApplicationConfiguraton.set_defaults_if_properties_are_not_set(configuration);
            migrator.Run();
        }

        public static void InitMigrationDbStructure(string connectionString)
        {
            Migrate migrator = new Migrate().Set(c =>
            {
                c.Logger = new ConsoleLogger();
                c.ConnectionString = connectionString;
                c.SqlFilesDirectory = MIGRATION_PATH;
                c.SprocsFolderName = @"dbo\Stored Procedures";
                c.ViewsFolderName = @"dbo\Views";
                c.FunctionsFolderName = @"dbo\Functions";
                c.UpFolderName = @"Scripts\Migrations\up";
                c.RunBeforeUpFolderName = @"Scripts\Migrations\runbeforeup";
                c.RunFirstAfterUpFolderName = @"Scripts\Migrations\runfirstafterup";
                c.DownFolderName = @"Scripts\Migrations\down";
                c.Restore = false;
                c.Silent = true;
                c.Baseline = true;
                c.WithTransaction = true;
                c.UsingVSDBProjectScripts = true;
            });

            var configuration = migrator.GetConfiguration();
            ApplicationConfiguraton.set_defaults_if_properties_are_not_set(configuration);
            migrator.Run();
        }
    }
}
