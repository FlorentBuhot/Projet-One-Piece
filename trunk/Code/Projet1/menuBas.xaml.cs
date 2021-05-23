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
    /// Logique d'interaction pour menuBas.xaml
    /// </summary>
    public partial class menuBas : UserControl
    {
        public Navigator Navigator => (App.Current as App).Navigator;
        public menuBas()
        {
            InitializeComponent();
        }
        private void ClickAnnuler(object sender, RoutedEventArgs e)
        {
            Navigator.NavigateTo(Navigator.PART_AJT_IMG_PERSO);
        }

        private void ClickAjouter(object sender, RoutedEventArgs e)
        {

        }
    }
}
