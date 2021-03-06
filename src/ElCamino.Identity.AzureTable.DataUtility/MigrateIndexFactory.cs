﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElCamino.Identity.AzureTable.DataUtility
{
    public static class MigrationFactory
    {
        public const string EmailIndex = "emailindex";
        public const string LoginIndex = "loginindex";
        public const string ClaimRowkey = "claimrowkey";


        public static IMigration CreateMigration(string migrateCommand)
        {
            string cmd = migrateCommand.ToLower();
            switch(cmd)
            {
                case EmailIndex:
                    return new EmailMigrateIndex();
                case LoginIndex:
                    return new LoginMigrateIndex();
                case ClaimRowkey:
                    return new ClaimMigrateRowkey();
                default:
                    break;
            }
            return null;
        }
    }
}
