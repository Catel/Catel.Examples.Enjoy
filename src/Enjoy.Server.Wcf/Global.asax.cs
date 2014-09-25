// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Global.asax.cs" company="Catel development team">
//   Copyright (c) 2008 - 2013 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Enjoy
{
    using System;
    using Catel.IoC;
    using Catel.Logging;
    using Data.Services;

    public class Global : System.Web.HttpApplication
    {
        #region Methods
        protected void Application_Start(object sender, EventArgs e)
        {
#if DEBUG
            LogManager.AddDebugListener(true);
#endif

            var dependencyResolver = this.GetDependencyResolver();
            var dbCreatorService = dependencyResolver.Resolve<IDbCreatorService>();
            dbCreatorService.CreateDatabaseIfRequired();
        }

        protected void Session_Start(object sender, EventArgs e)
        {
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
        }

        protected void Application_Error(object sender, EventArgs e)
        {
        }

        protected void Session_End(object sender, EventArgs e)
        {
        }

        protected void Application_End(object sender, EventArgs e)
        {
        }
        #endregion
    }
}