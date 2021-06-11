using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClassLibrary1;

namespace Projet1
{
    /// <summary>
    /// Logique d'interaction pour DescriptionPerso.xaml
    /// </summary>
    public partial class DescriptionPerso : UserControl
    {
        public Manager MonManager => (App.Current as App).MonManager;
        public DescriptionPerso()
        {
            InitializeComponent();
            DataContext = MonManager;
        }
        private void ClickImagePerso(object sender, RoutedEventArgs e)
        {
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.AJT_IMG_PERSO;
        }
        private void ClickInfoPerso(object sender, RoutedEventArgs e)
        {
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.INFO_PERSO;
        }
    }
}
