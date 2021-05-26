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

namespace Projet1
{
    /// <summary>
    /// Logique d'interaction pour ajouterInfoPerso.xaml
    /// </summary>
    public partial class ajouterInfoPerso : UserControl
    {
        public ajouterInfoPerso()
        {
            InitializeComponent();
        }
        private void ClickAnnuler(object sender, RoutedEventArgs e)
        {
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.PERSONNAGE;
        }

        private void ClickAjouter(object sender, RoutedEventArgs e)
        {
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.PERSONNAGE;
        }
    }
}
