using System;
using System.IO;
using System.Reflection;

namespace TeelSys.Settings
{
    public static class AssemblyInformation
    {
        #region Public Methods
        public static AssemblyDetails GetAssemblyDetails()
        {
            Assembly assembly = GetMainAssembly();

            return new AssemblyDetails(GetAssemblyCompany(assembly), GetAssemblyCopyright(assembly), GetAssemblyDescription(assembly), GetAssemblyName(assembly), GetAssemblyTitle(assembly), GetAssemblyVersion(assembly));
        }
        #endregion

        #region Private Methods
        private static string GetAssemblyCompany(Assembly assembly)
        {
            object[] attributes = assembly.GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
            if (attributes.Length == 0)
            {
                return "";
            }
            return ((AssemblyCompanyAttribute)attributes[0]).Company;
        }

        private static string GetAssemblyCopyright(Assembly assembly)
        {
            object[] attributes = assembly.GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
            if (attributes.Length == 0)
            {
                return "";
            }
            return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
        }

        private static string GetAssemblyDescription(Assembly assembly)
        {
            object[] attributes = assembly.GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
            if (attributes.Length == 0)
            {
                return "";
            }
            return ((AssemblyDescriptionAttribute)attributes[0]).Description;
        }

        private static string GetAssemblyName(Assembly assembly)
        {
            object[] attributes = assembly.GetCustomAttributes(typeof(AssemblyProductAttribute), false);
            if (attributes.Length == 0)
            {
                return "";
            }
            return ((AssemblyProductAttribute)attributes[0]).Product;
        }

        private static string GetAssemblyTitle(Assembly assembly)
        {
            object[] attributes = assembly.GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
            if (attributes.Length > 0)
            {
                AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                if (titleAttribute.Title != "")
                {
                    return titleAttribute.Title;
                }
            }
            return System.IO.Path.GetFileNameWithoutExtension(assembly.CodeBase);
        }

        private static string GetAssemblyVersion(Assembly assembly)
        {
            return assembly.GetName().Version.ToString();
        }

        private static Assembly GetMainAssembly()
        {
            string execPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, AppDomain.CurrentDomain.FriendlyName);

            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                if (assembly.Location == execPath)
                {
                    return assembly;
                }
            }

            return null;
        }
        #endregion
    }
}
