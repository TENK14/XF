using System;
using System.Collections.Generic;
using System.Text;
using XF.Models;

namespace XF.Services
{
	public class CustomerService
	{
		public CustomerService()
		{

		}

		public List<Customer> GetCustomers()
		{
			var list = new List<Customer>
			{
				new Customer
				{
					Id = 1,
					FirstName = "John",
					LastName = "First"
				},
				new Customer
				{
					Id = 2,
					FirstName = "Tim",
					LastName = "Second"
				},
				new Customer
				{
					Id = 3,
					FirstName = "Bron",
					LastName = "Third"
				},
			};

			return list;
		}
	}
}
