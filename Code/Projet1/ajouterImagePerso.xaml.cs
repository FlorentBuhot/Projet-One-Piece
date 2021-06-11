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
    /// Logique d'interaction pour ajouterImagePerso.xaml
    /// </summary>
    public partial class ajouterImagePerso : UserControl
    {
        public Manager MonManger => (App.Current as App).MonManager;
        ClassLibrary1.Image NouvelleImage { get; set; }
        
        public ajouterImagePerso()
        {
            InitializeComponent();
            NouvelleImage = new ClassLibrary1.Image();
            DataContext = MonManger.PersoAfficher;
        }

        private void Bouton_Parcourir(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.InitialDirectory = @"C:\Utilisateurs";
            dialog.FileName = "Image_Perso";
            dialog.DefaultExt = ".jpg | .png | .gif";

            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                string filename = dialog.FileName;
                image_perso1.Source = new BitmapImage(new Uri(filename, UriKind.Absolute));
            }
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
