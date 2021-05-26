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
        Arc NouvelleDesc { get; set; }
        Manager MonManager => (App.Current as App).MonManager;
        public AjouterInfoArc()
        {
            InitializeComponent();
            NouvelleDesc = new Arc("Laboon");
            NouvelleDesc.Info = "hehe je suis la description";
            DataContext = NouvelleDesc;
        }
        private void ClickAnnuler(object sender, RoutedEventArgs e)
        {
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }

        private void ClickAjouter(object sender, RoutedEventArgs e)
        {

        }
    }
}
