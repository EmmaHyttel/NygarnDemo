namespace NygarnDemo.Helpers;

public class UserIdGenerator
{
    public string GenerateUserId()
    {
        return Guid.NewGuid().ToString();
    }
}
