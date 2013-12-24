using System;
using System.EnterpriseServices.Internal;
using Catel.Reflection;

/// <summary>
/// Used by the ModuleInit. All code inside the Initialize method is ran as soon as the assembly is loaded.
/// </summary>
public static class ModuleInitializer
{
    /// <summary>
    /// Initializes the module.
    /// </summary>
    public static void Initialize()
    {
        Catel.IoC.ServiceLocator.Default.AutoRegisterTypesViaAttributes = true;

        AppDomain.CurrentDomain.PreloadAssemblies();
    }
}