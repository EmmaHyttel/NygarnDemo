namespace NygarnDemo.Helpers;

public class ProductIdGenerator
{
	public string GenerateProductId()
	{
		return Guid.NewGuid().ToString();
	}
}
