using System;
using System.Resources;

namespace TeelSys.Globalization
{
    public static class LocalizedResourceHelper
    {
        public static string GetLocalizedText(ResourceManager resourceManager, string resourceName, string defaultValue, bool skipChecks = false)
        {
            if (!skipChecks)
            {
                if (resourceManager == null || string.IsNullOrEmpty(resourceName))
                    return defaultValue;
            }

            string localizedText = resourceManager.GetString(resourceName);

            if (string.IsNullOrEmpty(localizedText))
                return defaultValue;

            return localizedText;
        }

        public static void LocalizeControlText(ResourceManager resourceManager, Object control, string resourceName, bool skipChecks = false)
        {
            if (!skipChecks)
            {
                if (resourceManager == null || control == null)
                    return;

                if (control.GetType().GetProperty("Text") == null)
                    return;
            }

            string localizedText = resourceManager.GetString(resourceName);

            if (string.IsNullOrEmpty(localizedText))
                return;

            control.GetType().GetProperty("Text").SetValue(control, localizedText);
        }

        public static void LocalizeControlText(ResourceManager resourceManager, Object control)
        {
            if (resourceManager == null || control == null)
                return;

            if (control.GetType().GetProperty("Name") == null || control.GetType().GetProperty("Text") == null)
                return;

            string resourceName = control.GetType().GetProperty("Name").GetValue(control).ToString() + ".Text";

            LocalizeControlText(resourceManager, control, resourceName, true);
        }
    }
}
