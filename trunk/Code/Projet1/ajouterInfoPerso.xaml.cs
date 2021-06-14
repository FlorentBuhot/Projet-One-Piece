using ClassLibrary1;
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
        public Manager MonManager => (App.Current as App).MonManager;
        public Personnage LePerso { get; set; }
        string info;
        public ajouterInfoPerso()
        {
            InitializeComponent();
            LePerso = new Personnage();
            LePerso.Info = MonManager.PersoAfficher.Info;
            DataContext = LePerso;
        }
        private void ClickAnnuler(object sender, RoutedEventArgs e)
        {
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ACCUEIL;
        }

        private void ClickAjouter(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Info.Text))
            {
                MessageBox.Show("Pas d'image à ajouter", "Erreur de saisie");
                return;
            }
            info = Info.Text;
            MonManager.PersoAfficher.Info = info;
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.PERSONNAGE;
        }
    }
}
