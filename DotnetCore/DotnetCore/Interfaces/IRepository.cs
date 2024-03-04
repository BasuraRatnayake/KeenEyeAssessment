namespace DotnetCore.Test1;

public interface IRepository<T> {
	void Add(T item);
	void Remove(T item);
	IEnumerable<T> GetAll();
}
