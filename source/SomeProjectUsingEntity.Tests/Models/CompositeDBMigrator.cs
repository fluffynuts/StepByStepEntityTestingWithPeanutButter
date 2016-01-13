using System;
using System.Runtime.InteropServices;
using PeanutButter.FluentMigrator;
using PeanutButter.TestUtils.Entity;
using SomeProjectUsingEntity.DbMigrations;

namespace SomeProjectUsingEntity.Tests.Models
{
    public class CompositeDBMigrator: IDBMigrationsRunner
    {
        private DbSchemaImporter _schemaImporter;
        private bool _logMigrations;
        private MigrationsRunner _migrationsRunner;

        public CompositeDBMigrator(string connectionString, bool logMigrations)
        {
            _logMigrations = logMigrations;
            _schemaImporter = new DbSchemaImporter(connectionString, SomeDBSchema.DB_SCHEMA);
            _migrationsRunner = new MigrationsRunner(connectionString, LogMigration);
        }

        private void LogMigration(string message)
        {
            if (_logMigrations)
                Console.WriteLine(message);
        }

        public void MigrateToLatest()
        {
            _schemaImporter.MigrateToLatest();
            _migrationsRunner.MigrateToLatest();
        }
    }
}