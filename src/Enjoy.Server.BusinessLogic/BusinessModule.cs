// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BusinessModule.cs" company="Catel development team">
//   Copyright (c) 2008 - 2014 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Enjoy.Business
{
    using Catel;
    using Catel.IoC;
    using Engines;

    public class BusinessModule : IServiceLocatorInitializer
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

            serviceLocator.RegisterType<ICategoryEngine, CategoryEngine>(RegistrationType.Transient);
        }
        #endregion
    }
}