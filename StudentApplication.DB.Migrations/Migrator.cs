﻿using System;
using FluentMigrator.Runner.Processors.SqlServer;

namespace StudentApplication.DB.Migrations
{
    public class Migrator : PeanutButter.FluentMigrator.DBMigrationsRunner<SqlServer2012ProcessorFactory>
    {
        public Migrator(string connectionString, Action textWriterAction = null) : base(typeof(Migrator).Assembly,
            connectionString, null)
        {

        }
    }
}