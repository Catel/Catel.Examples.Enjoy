// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UserRepository.cs" company="Catel development team">
//   Copyright (c) 2008 - 2013 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Enjoy.Repositories
{
    using System.Data.Entity;
    using Catel.Data.Repositories;
    using Catel.IoC;
    using Enjoy.DAL;

    [ServiceLocatorRegistration(typeof (IUserRepository), RegistrationType.Transient)]
    public class UserRepository : EntityRepositoryBase<User, int>, IUserRepository
    {
        #region Constructors
        public UserRepository(DbContext dbContext)
            : base(dbContext)
        {
        }
        #endregion
    }
}