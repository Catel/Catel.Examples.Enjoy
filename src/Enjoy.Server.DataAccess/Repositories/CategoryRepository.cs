// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CategoryRepository.cs" company="Catel development team">
//   Copyright (c) 2008 - 2014 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Enjoy.Data.Repositories
{
    using System.Data.Entity;
    using Catel.Data.Repositories;
    using Entities;

    public class CategoryRepository : EntityRepositoryBase<Category, int>, ICategoryRepository
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryRepository"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public CategoryRepository(DbContext dbContext)
            : base(dbContext)
        {
        }
        #endregion
    }
}