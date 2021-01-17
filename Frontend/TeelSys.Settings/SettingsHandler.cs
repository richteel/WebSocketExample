using System;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace TeelSys.Settings
{
    public class SettingsHandler
    {
        public string SettingsFile { get; set; }

        public bool DeleteSettingsFile()
        {
            try
            {
                if (File.Exists(SettingsFile))
                {
                    File.Delete(SettingsFile);
                }
                return !File.Exists(SettingsFile);
            }
            catch (UnauthorizedAccessException)
            {
                return false;
            }
        }

        public object LoadSettings(Type SettingsObjectType)
        {
            object retval = Activator.CreateInstance(SettingsObjectType);

            try
            {
                if (!File.Exists(SettingsFile))
                    return null;

                DataContractSerializer serializer = new DataContractSerializer(SettingsObjectType);

                using (XmlReader reader = XmlReader.Create(SettingsFile))
                {
                    retval = serializer.ReadObject(reader);
                }
            }
            catch (SerializationException)
            {
                //System.Windows.Forms.MessageBox.Show("Error loading configuration file. Default values will be used.\n\n" + e.Message);
                return null;
            }

            return retval;
        }

        public SettingsHandler(SettingFileTypes settingType)
        {
            SettingsFile = GetSettingsPath(settingType);

            if (!Directory.Exists(Path.GetDirectoryName(SettingsFile)))
                Directory.CreateDirectory(Path.GetDirectoryName(SettingsFile));
        }

        public bool SaveSettings(Object SettingsObject)
        {
            if (SettingsObject == null)
                return false;

            //XmlSerializer serializer = new XmlSerializer(SettingsObject.GetType());
            DataContractSerializer serializer = new DataContractSerializer(SettingsObject.GetType());

            if (!DeleteSettingsFile())
                return false;

            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(SettingsFile, Encoding.UTF8) { Formatting = Formatting.Indented })
                {
                    serializer.WriteObject(writer, SettingsObject);
                }

                return true;
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message, "Error writing to the configuration file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }

        private string GetSettingsPath(SettingFileTypes settingType)
        {
            // Application Settings
            if(settingType == SettingFileTypes.Application)
            {
                string executablePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, AppDomain.CurrentDomain.FriendlyName);
                return Regex.Replace(executablePath, @"\.exe\z", ".xml", RegexOptions.IgnoreCase);
            }

            // User Settings

            AssemblyDetails assemblyInfo = AssemblyInformation.GetAssemblyDetails();
            string retval = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            if (!string.IsNullOrEmpty(assemblyInfo.Company))
                retval = Path.Combine(retval, assemblyInfo.Company);


            if (!string.IsNullOrEmpty(assemblyInfo.Name))
                retval = Path.Combine(retval, assemblyInfo.Name);
            else if (!string.IsNullOrEmpty(assemblyInfo.Title))
                retval = Path.Combine(retval, assemblyInfo.Title);

            if (!string.IsNullOrEmpty(assemblyInfo.Version))
                retval = Path.Combine(retval, assemblyInfo.Version);

#if DEBUG
            retval = Path.Combine(retval, "Debug");
#endif

            retval = Path.Combine(retval, AppDomain.CurrentDomain.FriendlyName);

            return Regex.Replace(retval, @"\.exe\z", ".xml", RegexOptions.IgnoreCase); ;
        }
    }
}