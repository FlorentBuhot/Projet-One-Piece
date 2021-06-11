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
        public ajouterInfoPerso()
        {
            InitializeComponent();
            var p = MonManager.PersoAfficher;
            LePerso = new Personnage(p.Nom, p.Prénom, p.Info, p.Age, p.ListHaki, p.ImgBase, p.Appart, p.ListeArc);
            DataContext = LePerso;
        }
        private void ClickAnnuler(object sender, RoutedEventArgs e)
        {
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.PERSONNAGE;
        }

        private void ClickAjouter(object sender, RoutedEventArgs e)
        {
            MonManager.AjouterInfoPerso(MonManager.PersoAfficher, LePerso);
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.PERSONNAGE;
        }
    }
}
