// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CategoryRepository.cs" company="Catel development team">
//   Copyright (c) 2008 - 2013 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Enjoy.Repositories
{
    using System.Data.Entity;
    using Catel.Data.Repositories;
    using Catel.IoC;
    using Enjoy.DAL;

    [ServiceLocatorRegistration(typeof(IItemRepository), ServiceLocatorRegistrationMode.Transient)]
    public class ItemRepository : EntityRepositoryBase<Item, int>, IItemRepository
    {
        public ItemRepository(DbContext dbContext) 
            : base(dbContext)
        {
        }
    }
}