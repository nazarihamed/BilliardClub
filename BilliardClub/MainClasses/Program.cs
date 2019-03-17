﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilliardClub.Forms;

namespace BilliardClub
{
    static class Program
    {


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataBaseDataContext myConnection = Setting.DataBase;
            if (!myConnection.DatabaseExists())
            {
                myConnection.CreateDatabase();

                for (int i = 0; i < 24; i++)
                {
                    RaspberryPin.Insert(i.ToString(), true, myConnection);
                }
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
}
