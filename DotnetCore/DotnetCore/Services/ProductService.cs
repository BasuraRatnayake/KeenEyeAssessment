using DotnetCore.Interfaces;
using DotnetCore.Models;

namespace DotnetCore.Services;

public class ProductService : IProductService {
	public IEnumerable<Product> GetAll() {
		List<Product> products = new() {
			new Product(){ Id = 1, Name = "Product 1"},
			new Product(){ Id = 2, Name = "Product 3"},
		};

		return products.AsEnumerable();
	}
}
