using System;

namespace TeelSys.Settings
{
    public class SettingsEventArgs : EventArgs
    {
        public SettingsEventActions ChangeAction { get; }
        public string ActionFrom { get; }

        public SettingsEventArgs(SettingsEventActions ChangeAction, string ActionFrom)
        {
            this.ChangeAction = ChangeAction;
            this.ActionFrom = ActionFrom;
        }
    }
}
