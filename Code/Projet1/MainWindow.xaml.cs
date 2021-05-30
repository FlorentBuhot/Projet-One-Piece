using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = (App.Current as App).Navigator;
        }

        private void Clique_accueil(object sender, RoutedEventArgs e)
        {
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ACCUEIL;
        }

        private void Clique_ajt_perso(object sender, RoutedEventArgs e)
        {
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.PERSONNAGE;
        }

        public ContentControl GetContent()
        {
            return content;
        }

        private void rechercheArc(object sender, RoutedEventArgs e)
        {
            (App.Current as App).MonManager.ArcAfficher = (App.Current as App).MonManager.RechercherArc(ArcCherche.Text);
            if ((App.Current as App).MonManager.ArcAfficher != null) 
            {
                (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
            }
        }

        private void recherchePerso(object sender, RoutedEventArgs e)
        {
            (App.Current as App).MonManager.PersoAfficher = (App.Current as App).MonManager.RechercherPerso(PersoCherche.Text);
            if ((App.Current as App).MonManager.PersoAfficher != null)
            {
                (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.PERSONNAGE;
            }
        }
    }
}
