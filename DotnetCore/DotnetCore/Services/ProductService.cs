using DotnetCore.Interfaces;
using DotnetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetCore.Services;

public class ProductService : IProductService {
	private readonly DatabaseService database;

	public ProductService(DatabaseService database) {
		this.database = database;
	}

	public IEnumerable<Product> GetAll() {
		List<Product> products = new() {
			new Product(){ Id = 1, Name = "Product 1"},
			new Product(){ Id = 2, Name = "Product 3"},
		};

		return products.AsEnumerable();
	}

	public async Task<Product> GetOne(int id) {
		return await database.Products.FirstOrDefaultAsync(p => p.Id == id);

	}
}
