
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalApp.Models
{
	public class Photo
	{

		public int Id { get; set; }
		public string Url { get; set; }
		public string Description { get; set; }
		public virtual User User { get; set; }
		public int UserId { get; set; }
	}
}