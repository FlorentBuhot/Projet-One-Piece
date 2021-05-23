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

namespace Projet1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Navigator Navigator => (App.Current as App).Navigator;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Clique_accueil(object sender, RoutedEventArgs e)
        {
            content.Content = new Accueil();
        }

        private void Clique_ajt_perso(object sender, RoutedEventArgs e)
        {
            content.Content = new AjoutPerso();
        }

        public ContentControl GetContent()
        {
            return content;
        }

        private void rechercheArc(object sender, RoutedEventArgs e)
        {

        }

        private void recherchePerso(object sender, RoutedEventArgs e)
        {

        }
    }
}
