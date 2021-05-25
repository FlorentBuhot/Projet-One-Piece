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
    /// Logique d'interaction pour Accueil.xaml
    /// </summary>
    public partial class Accueil : UserControl
    {
        public Accueil()
        {
            InitializeComponent();
        }


        private void myPolygon_Click(object sender, RoutedEventArgs e)
        {
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.AJT_IMG_ARC;
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            (App.Current as App).MonManager.ArcAAfficher(0);
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            (App.Current as App).MonManager.ArcAAfficher(1);
            (App.Current as App).Navigator.EtatEnCours = Navigator.EtatUC.ARC;
        }

        private void Laboon(object sender, RoutedEventArgs e)
        {

        }

        private void Longue_Town(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {

        }
    }
}
