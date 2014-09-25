// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CategoryEngine.cs" company="Catel development team">
//   Copyright (c) 2008 - 2014 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Enjoy.Business.Engines
{
    using System;
    using System.Collections.Generic;
    using Catel;
    using Data.Entities;
    using Data.Repositories;

    public class CategoryEngine : EntityEngineBase<Category>, ICategoryEngine
    {
        #region Fields
        private readonly ICategoryRepository _categoryRepository;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryEngine"/> class.
        /// </summary>
        /// <param name="categoryRepository">The category repository.</param>
        /// <exception cref="System.ArgumentNullException">The <paramref name="categoryRepository" /> is <c>null</c>.</exception>
        public CategoryEngine(ICategoryRepository categoryRepository)
        {
            Argument.IsNotNull(() => categoryRepository);
            _categoryRepository = categoryRepository;
        }
        #endregion

        #region ICategoryEngine Members
        public override void GetData(Action<IEnumerable<Category>> completed = null)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}