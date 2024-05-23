using NygarnDemo.Enums;
using NygarnDemo.Models;

namespace NygarnDemo.Services.Interfaces
{
	public interface IGenericProductService<T>
	{
		Task<List<T>> NameSearch(string str);
		Task<List<T>> PriceFilter(int maxPrice, int minPrice = 0);
		Task<List<T>> ColorFilter(Color color);
		Task<List<T>> MaterialFilter(Material material);
		Task<List<T>> BrandFilter(string brand);
		Task<List<T>> KnittingTensionFilter(string knittigTension);
		Task<List<T>> YardageFilter(string yardage);
		Task<List<T>> SizeFilter(Size size);
		Task<IEnumerable<T>> TypeSearch(string type);
		IEnumerable<T> CategoryFilter(Category category);
		IEnumerable<T> FitsFilter(Fits fits);
		IEnumerable<T> DiffLevelFilter(string difficultyLevel);
		IEnumerable<T> MaterialFilter(NeedleAndHookMaterial material);

		IEnumerable<T> NeedleTypeFilter(NeedleType type);
	}
}
