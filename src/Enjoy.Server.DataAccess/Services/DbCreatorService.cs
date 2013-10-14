// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DbCreatorService.cs" company="Catel development team">
//   Copyright (c) 2008 - 2013 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Enjoy.Services
{
    using Catel.Data;
    using Catel.IoC;
    using Catel.Logging;
    using Enjoy.DAL;

    [ServiceLocatorRegistration(typeof(IDbCreatorService))]
    public class DbCreatorService : IDbCreatorService
    {
        private static readonly ILog Log = LogManager.GetCurrentClassLogger();

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
    }
}