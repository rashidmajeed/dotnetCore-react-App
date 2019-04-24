using Microsoft.EntityFrameworkCore;
using RentalApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentalApp.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options) { }

		public DbSet<User> Users { get; set; }
		public DbSet<Photo> Photos {get; set;}
		public DbSet<Rental> Rentals {get; set;}
		
	}

}
