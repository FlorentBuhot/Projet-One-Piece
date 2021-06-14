﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ClassLibrary1;

namespace Projet1
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public Manager MonManager { get; set; } = new Manager(new DataContractPersistance.DataContractPers());

        public Navigator Navigator { get; private set; } = new Navigator();

        public App() : base()
        {
            MonManager.ChargeDonnees();
        }

        private void Application_Exit(object sender, ExitEventArgs e)
        {
            MonManager.SauvegardeDonnees();
        }
    }
}