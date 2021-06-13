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
    /// Logique d'interaction pour DescriptionArc.xaml
    /// </summary>
    public partial class DescriptionArc : UserControl
    {
        public DescriptionArc()
        {
            InitializeComponent();
            
            DataContext = (App.Current as App).MonManager;
        }

        private void ClickImageArc(object sender, RoutedEventArgs e)
        {
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.AJT_IMG_ARC;
        }
        private void ClickInfoArc(object sender, RoutedEventArgs e)
        {
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.AJT_INFO_ARC;
        }

        private void ArcPre(object sender, RoutedEventArgs e)
        {
            if (((App.Current as App).MonManager.NumArc - 1) >= 0)
            {
                (App.Current as App).MonManager.ArcAAfficher((App.Current as App).MonManager.NumArc - 1);
                (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
            }
        }

        private void ArcSuiv(object sender, RoutedEventArgs e)
        {
            if (((App.Current as App).MonManager.NumArc + 1) < (App.Current as App).MonManager.ListeArc.Count)
            {
                (App.Current as App).MonManager.ArcAAfficher((App.Current as App).MonManager.NumArc + 1);
                (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
            }
        }

        private void Liste_Perso(object sender, SelectionChangedEventArgs e)
        {
            Personnage perso = ((sender as ListBox).SelectedItem as Personnage);
            (App.Current as App).MonManager.PersoAfficher = perso;
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.PERSONNAGE;
        }
    }
}
