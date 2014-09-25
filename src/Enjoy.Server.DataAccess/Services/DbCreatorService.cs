// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DbCreatorService.cs" company="Catel development team">
//   Copyright (c) 2008 - 2014 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Enjoy.Data.Services
{
    using Anotar.Catel;
    using Catel.Data;

    public class DbCreatorService : IDbCreatorService
    {
        #region IDbCreatorService Members
        /// <summary>
        /// Creates the database if required.
        /// </summary>
        public void CreateDatabaseIfRequired()
        {
            using (var dbContextManager = DbContextManager<EnjoyDbContext>.GetManager())
            {
                var dbContext = dbContextManager.Context;

                if (!dbContext.Database.Exists())
                {
                    LogTo.Info("Database does not exist, creating a new database");

                    if (!dbContext.Database.CreateIfNotExists())
                    {
                        LogTo.Error("Failed to create the database");
                    }
                    else
                    {
                        LogTo.Info("Created database");
                    }
                }
            }
        }
        #endregion
    }
}