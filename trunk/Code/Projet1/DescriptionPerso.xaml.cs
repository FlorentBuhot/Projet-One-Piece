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
    /// Logique d'interaction pour DescriptionPerso.xaml
    /// </summary>
    public partial class DescriptionPerso : UserControl
    {
        Manager MonManager => (App.Current as App).MonManager;
        Personnage Luffy { get; set; }
        Haki LuffyHaki { get; set; }
        Appartennance LuffyAppart { get; set; }
        List<ClassLibrary1.Image> Luffyimage { get; set; }
        ClassLibrary1.Image Image1 { get; set; }
        public DescriptionPerso()
        {
            InitializeComponent();
            Luffy = new Personnage();
            Luffy.Prénom = "Luffy";
            Luffy.Nom = "Monkey D.";
            Luffy.Info = "Luffy est bel et bien le personnage principale de l'histoire de One Piece";
            Luffy.Age = 18;
            LuffyHaki = new Haki("Haki des rois","Un truc trop fort");
            Luffy.Haki = LuffyHaki;
            LuffyAppart = new Appartennance("Pirate au Chapeau de Paille", "2quipage trop fort");
            Luffy.Appart = LuffyAppart;
            Luffyimage = new List<ClassLibrary1.Image>();
            Image1 = new ClassLibrary1.Image("ImagePerso\ancien_luffy.png", "Luffy au début");
            Luffyimage.Add(Image1);
            DataContext = Luffy;
        }
        private void ClickImagePerso(object sender, RoutedEventArgs e)
        {

        }
        private void ClickInfoPerso(object sender, RoutedEventArgs e)
        {

        }
    }
}
