// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CosturaHelper.cs" company="Catel development team">
//   Copyright (c) 2008 - 2013 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Enjoy
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Catel.Logging;

    public static class CosturaHelper
    {
        private static readonly ILog Log = LogManager.GetCurrentClassLogger();

        public static void LoadAssemblies()
        {
            var assemblyLoader = Type.GetType("Costura.AssemblyLoader");
            var assembliesAsResourcesFieldInfo = assemblyLoader.GetField("assemblyNames", BindingFlags.Static | BindingFlags.NonPublic);
            var assembliesAsResources = (Dictionary<string, string>)assembliesAsResourcesFieldInfo.GetValue(null);

            var symbolsAsResourcesFieldInfo = assemblyLoader.GetField("symbolNames", BindingFlags.Static | BindingFlags.NonPublic);
            var symbolsAsResources = (Dictionary<string, string>)symbolsAsResourcesFieldInfo.GetValue(null);

            var readFromEmbeddedResourcesMethodInfo = assemblyLoader.GetMethod("ReadFromEmbeddedResources", BindingFlags.Static | BindingFlags.NonPublic);
            foreach (var assemblyKeyValuePair in assembliesAsResources)
            {
                Log.Debug("Forcing load from Costura packed assembly '{0}'", assemblyKeyValuePair.Key);

                readFromEmbeddedResourcesMethodInfo.Invoke(null, new object[] { assembliesAsResources, symbolsAsResources, assemblyKeyValuePair.Key });
            }
        }
    }
}