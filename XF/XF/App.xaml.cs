using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using XF.Views;

namespace XF
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			//MainPage = new MainPage();
			//MainPage = new Page1();
			MainPage = new NavigationPage(new Page1());
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
