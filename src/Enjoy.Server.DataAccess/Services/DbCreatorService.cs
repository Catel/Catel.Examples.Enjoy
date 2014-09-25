// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DbCreatorService.cs" company="Catel development team">
//   Copyright (c) 2008 - 2014 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Enjoy.Data.Services
{
    using Catel.Data;
    using Catel.Logging;

    public class DbCreatorService : IDbCreatorService
    {
        #region Constants
        private static readonly ILog Log = LogManager.GetCurrentClassLogger();
        #endregion

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