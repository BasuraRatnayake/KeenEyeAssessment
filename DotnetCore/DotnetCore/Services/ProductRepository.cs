namespace DotnetCore.Test1;

public class ProductRepository<T> : IRepository<T> {
	public void Add(T item) {
		throw new NotImplementedException();
	}

	public IEnumerable<T> GetAll() {
		throw new NotImplementedException();
	}

	public void Remove(T item) {
		throw new NotImplementedException();
	}
}
