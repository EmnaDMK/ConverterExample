using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConverterExample.Converters;
using Xamarin.Forms;

namespace ConverterExample
{
	public partial class App : Application
	{
	    public App()
	    {
	        InitializeComponent();

            MainPage = new ConverterExample.MainPage();
            //MainPage = new ContentPage
            //{
            //    Content = new StackLayout
            //    {
            //        Children =
            //        {
            //            new Checkbox()
            //            {
            //                Color = Color.Blue
            //            }
            //        }


            //    }

            //};
        }

	    protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
