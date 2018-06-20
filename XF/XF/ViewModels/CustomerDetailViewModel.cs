using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XF.Models;

namespace XF.ViewModels
{
    public class CustomerDetailViewModel : ViewModelBase
    {
		public CustomerDetailViewModel(INavigation navigation, Customer customer)
		{
			this.navigation = navigation;
			Customer = customer;
		}

		private INavigation navigation;
		private Customer customer;
		public Customer Customer
		{
			get
			{
				return customer;
			}
			set
			{
				SetProperty(ref customer, value);
			}
		}
	}
}
