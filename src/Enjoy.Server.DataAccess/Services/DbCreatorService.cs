// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DbCreatorService.cs" company="Catel development team">
//   Copyright (c) 2008 - 2014 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Enjoy.Data.Services
{
    using Catel.Data;
    using Catel.Logging;
    using DAL;

    public class DbCreatorService : IDbCreatorService
    {
        #region Constants
        private static readonly ILog Log = LogManager.GetCurrentClassLogger();
        #endregion

        #region IDbCreatorService Members
        public void CreateDatabaseIfRequired()
        {
            using (var dbContextManager = DbContextManager<EnjoyDbContext>.GetManager())
            {
                var dbContext = dbContextManager.Context;

                if (!dbContext.Database.Exists())
                {
                    Log.Info("Database does not exist, creating a new database");

                    if (!dbContext.Database.CreateIfNotExists())
                    {
                        Log.Error("Failed to create the database");
                    }
                    else
                    {
                        Log.Info("Created database");
                    }
                }
            }
        }
        #endregion
    }
}