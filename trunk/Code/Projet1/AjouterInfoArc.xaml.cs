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
    /// Logique d'interaction pour AjouterInfoArc.xaml
    /// </summary>
    public partial class AjouterInfoArc : UserControl
    {
        Manager MonManager => (App.Current as App).MonManager;
        public Arc larc { get; set; }
        string info;
        public AjouterInfoArc()
        {
            InitializeComponent();
            larc = new Arc();
            larc.Info = MonManager.ArcAfficher.Info;
            DataContext = larc;
        }
        private void ClickAnnuler(object sender, RoutedEventArgs e)
        {
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }

        private void ClickAjouter(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Info.Text))
            {
                MessageBox.Show("Pas d'image à ajouter", "Erreur de saisie");
                return;
            }
            info = Info.Text;
            MonManager.ArcAfficher.Info = info;
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }
    }
}
