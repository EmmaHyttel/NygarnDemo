namespace NygarnDemo.Helpers;

public class PersonIdGenerator
{
    public string GeneratePersonId()
    {
        return Guid.NewGuid().ToString();
    }
}
