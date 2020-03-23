using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace blogcore.Data
{
	public class ContextFactory : IDesignTimeDbContextFactory<DataContext>
	{
		public DataContext CreateDbContext(string[] args = null)
		{
			IConfiguration conf = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

			string connectionString = conf.GetConnectionString("mssql");
			Debug.WriteLine("string:" + connectionString);
			DbContextOptionsBuilder<DataContext> builder = new DbContextOptionsBuilder<DataContext>();
			builder.UseSqlServer(connectionString);
			return new DataContext(builder.Options);


		}
	}
}
