
using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security;


#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

// General Information
[assembly: AssemblyTitle("Onlio Bank Account Demo Business Logic")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyCompany("Onlio, a.s.")]
[assembly: AssemblyProduct("Bank Account Demo")]
[assembly: AssemblyCopyright("Copyright © Onlio, a.s. 2012")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: NeutralResourcesLanguage("en-us")]

// Version information: <major>.<minor>.<build>.<revision>
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: AssemblyInformationalVersion("1.0")] // Product version

// Functional Flags
[assembly: Guid("685089f7-8ae8-4521-b9f2-5ae7321abc67")]

[assembly: CLSCompliant(true)]
[assembly: ComVisible(false)]
