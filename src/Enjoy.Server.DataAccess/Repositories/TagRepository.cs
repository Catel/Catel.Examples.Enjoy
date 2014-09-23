// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TagRepository.cs" company="Catel development team">
//   Copyright (c) 2008 - 2014 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Enjoy.Data.Repositories
{
    using System.Data.Entity;
    using Catel.Data.Repositories;
    using DAL;

    public class TagRepository : EntityRepositoryBase<Tag, int>, ITagRepository
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="TagRepository"/> class.
        /// </summary>
        /// <param name="dbContext">The database context.</param>
        public TagRepository(DbContext dbContext)
            : base(dbContext)
        {
        }
        #endregion
    }
}