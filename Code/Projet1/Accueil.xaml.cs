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

        private void BaggyLeClown(object sender, RoutedEventArgs e)
        {
            (App.Current as App).MonManager.ArcAAfficher(1);
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }

        private void Baratie(object sender, RoutedEventArgs e)
        {
            (App.Current as App).MonManager.ArcAAfficher(3);
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {

        }
        private void LogueTown(object sender, RoutedEventArgs e)
        {
            (App.Current as App).MonManager.ArcAAfficher(5);
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }
        private void Laboon(object sender, RoutedEventArgs e)
        {
            (App.Current as App).MonManager.ArcAAfficher(6);
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }

        private void Whiskey_Peak(object sender, RoutedEventArgs e)
        {
            (App.Current as App).MonManager.ArcAAfficher(7);
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }

        private void LittleGarden(object sender, RoutedEventArgs e)
        {
            (App.Current as App).MonManager.ArcAAfficher(8);
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }
        private void Button_Click_17(object sender, RoutedEventArgs e)
        {

        }
        private void Alabasta(object sender, RoutedEventArgs e)
        {
            (App.Current as App).MonManager.ArcAAfficher(10);
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }
        private void Jaya(object sender, RoutedEventArgs e)
        {
            (App.Current as App).MonManager.ArcAAfficher(11);
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }

        private void Skypiea(object sender, RoutedEventArgs e)
        {
            (App.Current as App).MonManager.ArcAAfficher(12);
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }
        private void Davy_Back_Fight(object sender, RoutedEventArgs e)
        {
            (App.Current as App).MonManager.ArcAAfficher(13);
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }
        private void Water7(object sender, RoutedEventArgs e)
        {
            (App.Current as App).MonManager.ArcAAfficher(14);
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }
        private void EniesLobby(object sender, RoutedEventArgs e)
        {
            (App.Current as App).MonManager.ArcAAfficher(15);
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }
        private void Archipel(object sender, RoutedEventArgs e)
        {
            (App.Current as App).MonManager.ArcAAfficher(18);
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }
        private void AmazonLily(object sender, RoutedEventArgs e)
        {
            (App.Current as App).MonManager.ArcAAfficher(19);
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }
        private void ImpelDown(object sender, RoutedEventArgs e)
        {
            (App.Current as App).MonManager.ArcAAfficher(20);
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }

        private void MarineFord(object sender, RoutedEventArgs e)
        {
            (App.Current as App).MonManager.ArcAAfficher(21);
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }
        private void PunkHazard(object sender, RoutedEventArgs e)
        {
            (App.Current as App).MonManager.ArcAAfficher(25);
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }
        private void Dresrosa(object sender, RoutedEventArgs e)
        {
            (App.Current as App).MonManager.ArcAAfficher(26);
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }
        private void Zou(object sender, RoutedEventArgs e)
        {
            (App.Current as App).MonManager.ArcAAfficher(28);
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }
        private void WanoKuni(object sender, RoutedEventArgs e)
        {
            (App.Current as App).MonManager.ArcAAfficher(31);
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }
    }
}
