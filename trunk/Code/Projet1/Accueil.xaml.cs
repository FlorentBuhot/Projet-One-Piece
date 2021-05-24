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
    /// Logique d'interaction pour Accueil.xaml
    /// </summary>
    public partial class Accueil : UserControl
    {
        public Accueil()
        {
            InitializeComponent();
        }


        private void myPolygon_Click(object sender, RoutedEventArgs e)
        {
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.AJT_IMG_ARC;
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            (App.Current as App).MonManager.ArcAAfficher(0);
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            (App.Current as App).MonManager.ArcAAfficher(1);
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }
    }
}
