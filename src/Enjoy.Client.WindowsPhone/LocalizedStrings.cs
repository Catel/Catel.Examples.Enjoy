// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LocalizedStrings.cs" company="Catel development team">
//   Copyright (c) 2008 - 2013 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Enjoy
{
    using Enjoy.Resources;

    /// <summary>
    /// Provides access to string resources.
    /// </summary>
    public class LocalizedStrings
    {
        #region Constants
        private static readonly AppResources _localizedResources = new AppResources();
        #endregion

        #region Properties
        public AppResources LocalizedResources
        {
            get { return _localizedResources; }
        }
        #endregion
    }
}