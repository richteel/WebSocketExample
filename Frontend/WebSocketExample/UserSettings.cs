using System;
using TeelSys.Settings;

namespace WebSocketExample
{
    [Serializable]
    public class UserSettings
    {
        /*** Properties ***/
        #region
        public TeelSys.Settings.WindowSettings MainFormProperties { get; set; }

        public string Server { get; set; }

        public int ServerPort { get; set; }

        public string Version { get; set; }
        #endregion

        /*** Constructor & Initialization ***/
        #region
        public UserSettings()
        {
            // Default Values
            AssemblyDetails assemblyInfo = AssemblyInformation.GetAssemblyDetails();
            Version = assemblyInfo.Version;
            ServerPort = 8080;
            Server = "";
            MainFormProperties = new WindowSettings();
        }
        #endregion
    }
}
