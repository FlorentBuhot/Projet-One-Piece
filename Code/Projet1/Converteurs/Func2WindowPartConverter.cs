using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Controls;
using System.Windows.Data;
using static Projet1.Navigator;

namespace Projet1
{
    public class Func2WindowPartConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            EtatUC e = (EtatUC)value;

            switch (e)
            {
                case Navigator.EtatUC.ACCUEIL:
                    return new Accueil();
                case Navigator.EtatUC.AJT_IMG_ARC:
                    return new ajoutImageArc();
                case Navigator.EtatUC.PERSONNAGE:
                    return new DescriptionPerso();
                case Navigator.EtatUC.ARC:
                    return new DescriptionArc();
                case Navigator.EtatUC.AJT_IMG_PERSO:
                    return new ajouterImagePerso();
                default:
                    break;
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
