using DotnetCore.Models;

namespace DotnetCore.Interfaces;

public interface IProductService {
	IEnumerable<Product> GetAll();
}
