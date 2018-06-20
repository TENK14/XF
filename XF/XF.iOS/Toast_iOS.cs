using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using XF.Interfaces;

[assembly: Xamarin.Forms.Dependency(typeof(XF.iOS.Toast_iOS))]
namespace XF.iOS
{
	public class Toast_iOS : IToast
	{
		public void Show(string message)
		{
			new UIAlertView("Tapped", message, null, "ok", null).Show();
		}
	}
}