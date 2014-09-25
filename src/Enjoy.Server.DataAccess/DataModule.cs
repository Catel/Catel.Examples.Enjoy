// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataModule.cs" company="Catel development team">
//   Copyright (c) 2008 - 2014 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Enjoy.Data
{
    using Catel;
    using Catel.IoC;
    using Repositories;
    using Services;

    public class DataModule : IServiceLocatorInitializer
    {
        #region IServiceLocatorInitializer Members
        /// <summary>
        /// Initializes the specified service locator.
        /// </summary>
        /// <param name="serviceLocator">The service locator.</param>
        /// <exception cref="System.ArgumentNullException">The <paramref name="serviceLocator" /> is <c>null</c>.</exception>
        public void Initialize(IServiceLocator serviceLocator)
        {
            Argument.IsNotNull(() => serviceLocator);

            serviceLocator.RegisterType<IDbCreatorService, DbCreatorService>();

            serviceLocator.RegisterType<ICategoryRepository, CategoryRepository>(RegistrationType.Transient);
            serviceLocator.RegisterType<IGroupRepository, GroupRepository>(RegistrationType.Transient);
            serviceLocator.RegisterType<IItemRepository, ItemRepository>(RegistrationType.Transient);
            serviceLocator.RegisterType<ITagRepository, TagRepository>(RegistrationType.Transient);
            serviceLocator.RegisterType<IUserRepository, UserRepository>(RegistrationType.Transient);
        }
        #endregion
    }
}