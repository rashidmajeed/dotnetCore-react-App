using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalApp.Models
{
	public class Rental
	{

		public int Id { get; set; }
		public string Title { get; set; }
		public string City { get; set; }
		public string Street { get; set; }
		public string Category { get; set; }
		public string ImageUrl { get; set; }
		public int Bedrooms { get; set; }
		public Boolean Shared { get; set; }
		public string Description { get; set; }
		public DateTime CreatedAt { get; set; }
		public virtual User User { get; set; }
		public int UserId {get; set;}
	}
}
