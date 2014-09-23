// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ItemRepository.cs" company="Catel development team">
//   Copyright (c) 2008 - 2014 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Enjoy.Data.Repositories
{
    using System.Data.Entity;
    using Catel.Data.Repositories;
    using DAL;

    public class ItemRepository : EntityRepositoryBase<Item, int>, IItemRepository
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemRepository"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public ItemRepository(DbContext dbContext)
            : base(dbContext)
        {
        }
        #endregion
    }
}