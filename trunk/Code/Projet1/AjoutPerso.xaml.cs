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
    /// Logique d'interaction pour AjoutPerso.xaml
    /// </summary>
    public partial class AjoutPerso : UserControl
    {
        Personnage NouveauPerso { get; set; }
        Manager MonManager => (App.Current as App).MonManager;
        public AjoutPerso()
        {
            InitializeComponent();
            NouveauPerso = new Personnage();
            NouveauPerso.Nom = "bonjour";
            DataContext = NouveauPerso;
        }

        private void Bouton_Parcourir(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.InitialDirectory = @"C:\Utilisateurs";
            dialog.FileName = "Image_Perso";
            dialog.DefaultExt = ".jpg | .png | .gif";

            bool? result = dialog.ShowDialog();

            if(result == true)
            {
                string filename = dialog.FileName;
                image_perso.Source = new BitmapImage(new Uri(filename, UriKind.Absolute));
            }
        }
        private void ClickAnnuler(object sender, RoutedEventArgs e)
        {
            
        }

        private void ClickAjouter(object sender, RoutedEventArgs e)
        {

        }
    }
}
