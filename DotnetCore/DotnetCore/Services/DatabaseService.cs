using DotnetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetCore.Services;

public class DatabaseService : DbContext {
	protected const string DB_NAME = "keeneye.db";
	protected string DB_PATH {
		get {
			return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DB_NAME);
		}
	}

	public DbSet<Product> Products { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite($"Data Source={DB_PATH}");
}
