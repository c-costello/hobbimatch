using System;
using Microsoft.AspNetCore.Identity;

namespace hobbimatchapi.Models
{
	public class User : IdentityUser
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public User()
		{
		}
	}
}

