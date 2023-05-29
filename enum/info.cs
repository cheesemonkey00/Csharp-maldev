using System;
using System.Diagnostics;
using System.Net;

namespace redTeamDev
{
    class GeneralInfo
    {
        public string oSystem; //string variable for storing operating system

            public string uName; //string variable for storing username
            public string cDirectory; // storing pwd
            public string pName; //storing procname
            public string ePath; //storing exe path
            public string ipv4; // store ip
        public string hostName;
            public string pID; // proc id
            public bool isAdmin; // check if user is admin

            public GeneralInfo(){

                oSystem = Environment.OSVersion.ToString();
                uName = Environment.UserName;
                cDirectory = Environment.CurrentDirectory;
                pName = Process.GetCurrentProcess().ProcessName;
                pID = Process.GetCurrentProcess().Id.ToString();
                ePath = Process.GetCurrentProcess().MainModule.FileName;
                hostName = Dns.GetHostName();
                ipv4 = Dns.GetHostEntry(hostName).AddressList[1].ToString();

                    using var identity = System.Security.Principal.WindowsIdentity.GetCurrent();
                var Principal = new System.Security.Principal.WindowsPrincipal(identity);
                    isAdmin = Principal.IsInRole(System.Security.Principal.WindowsBuiltInRole.Administrator);
            }

    }
}
