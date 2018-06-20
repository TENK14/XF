using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Models;
using XF.ViewModels;

namespace XF.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page3 : ContentPage
	{
		public Page3 (Customer customer)
		{
			InitializeComponent ();

			this.BindingContext = new CustomerDetailViewModel(Navigation, customer);
		}
	}
}