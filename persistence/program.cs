// See https://aka.ms/new-console-template for more information

using System;

namespace redTeamDev;

    class Program
    {
        static void Main(string[] args)
        {
            GeneralInfo infoObj = new GeneralInfo();
            Persistence persObj = new Persistence(infoObj);
            persObj.AddToStartup();
        }
    }

