using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace fpts.ViewModels
{
    public class HomeViewViewModel : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            if ((int)value > 4) // length > 0 ?
                return 1;            // some data has been entered
            else if ((int)value == 1) // length > 0 ?
                return 0;
            else
                return -1;            // input is empty
        }


        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }


    }
}