using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalApp.Models
{
	public class User
	{

		public int Id { get; set; }
		public string Username { get; set; }
		public byte[] PasswordHash { get; set; }
		public byte[] PasswordSalt { get; set; }
		public  string Gender { get; set; }
		public DateTime Created { get; set; }
		public string Country { get; set; }
		public virtual ICollection<Photo> Photos {get; set;}
		public virtual ICollection<Rental> Rentals {get; set;}

	}
}
