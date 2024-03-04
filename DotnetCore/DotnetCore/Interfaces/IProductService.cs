using DotnetCore.Models;

namespace DotnetCore.Interfaces;

public interface IProductService {
	IEnumerable<Product> GetAll();
	Task<Product> GetOne(int id);
}
