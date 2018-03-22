using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace ConverterExample
{
   public class Check : IValueConverter

    {

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)

        {

            if ((bool)value == true)

            {

                return "checked.png";

            }

            else

            {

                return "unchecked.png";

            }

        }



        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)

        {

            throw new NotImplementedException();

        }

    }

}