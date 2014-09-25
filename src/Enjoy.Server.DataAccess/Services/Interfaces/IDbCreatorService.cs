// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDbCreatorService.cs" company="Catel development team">
//   Copyright (c) 2008 - 2014 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Enjoy.Data.Services
{
    public interface IDbCreatorService
    {
        #region Methods
        /// <summary>
        /// Creates the database if required.
        /// </summary>
        void CreateDatabaseIfRequired();
        #endregion
    }
}