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
        ClassLibrary1.Image NouvelleImage { get; set; }
        Manager MonManager => (App.Current as App).MonManager;
        public ajouterImagePerso()
        {
            InitializeComponent();
            NouvelleImage = new ClassLibrary1.Image();
            NouvelleImage.Description = "Voici une jolie image";
            DataContext = NouvelleImage;
        }

        private void ClickAnnuler(object sender, RoutedEventArgs e)
        {

        }

        private void ClickAjouter(object sender, RoutedEventArgs e)
        {

        }
    }
}
