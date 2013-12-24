// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TagRepository.cs" company="Catel development team">
//   Copyright (c) 2008 - 2013 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Enjoy.Repositories
{
    using System.Data.Entity;
    using Catel.Data.Repositories;
    using Catel.IoC;
    using Enjoy.DAL;

    [ServiceLocatorRegistration(typeof(ITagRepository), ServiceLocatorRegistrationMode.Transient)]
    public class TagRepository : EntityRepositoryBase<Tag, int>, ITagRepository
    {
        #region Constructors
        public TagRepository(DbContext dbContext)
            : base(dbContext)
        {
        }
        #endregion
    }
}