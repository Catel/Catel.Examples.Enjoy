// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EntityEngineBase.cs" company="Catel development team">
//   Copyright (c) 2008 - 2014 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Enjoy.Business.Engines
{
    using System;
    using System.Collections.Generic;

    public abstract class EntityEngineBase<TModel> : IEntityEngine<TModel> where TModel : class
    {
        #region IEntityEngine<TModel> Members
        /// <summary>
        /// Gets the data. 
        /// <para />
        /// If the data is already loaded, it will immediately return.
        /// <para />
        /// If the data is currently loading, the handler will be queued and called as soon as the data is loaded.
        /// </summary>
        /// <param name="completed">The handler to call when the data is retrieved, can be <c>null</c>.</param>
        public abstract void GetData(Action<IEnumerable<TModel>> completed = null);
        #endregion
    }
}