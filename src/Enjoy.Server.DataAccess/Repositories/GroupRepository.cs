// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GroupRepository.cs" company="Catel development team">
//   Copyright (c) 2008 - 2014 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Enjoy.Data.Repositories
{
    using System.Data.Entity;
    using Catel.Data.Repositories;
    using DAL;

    public class GroupRepository : EntityRepositoryBase<Group, int>, IGroupRepository
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupRepository"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public GroupRepository(DbContext dbContext)
            : base(dbContext)
        {
        }
        #endregion
    }
}