using NygarnDemo.Models;

namespace NygarnDemo.Services.Interfaces
{
    public interface IAdminService
    {
        List<Admin> GetAdmins();

        IEnumerable<Admin> GetAdmins(string username);
    }
}
