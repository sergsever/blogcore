using blogcore.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

namespace blogcore.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(getOptions())
		{
			Database.EnsureCreated();
		}

		private static DbContextOptions<DataContext> getOptions()
		{
			IConfiguration conf = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

			string connectionString = conf.GetConnectionString("mssql");
			DbContextOptionsBuilder<DataContext> builder = new DbContextOptionsBuilder<DataContext>();
			builder.UseSqlServer(connectionString);
			return builder.Options;
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<Article>().HasData(
				new Article() { Title = "Title1", Date = DateTime.Now, Text = "Content", Id = 1 });
		}

		public DbSet<Article> Articles { get; set; }
	}
}
