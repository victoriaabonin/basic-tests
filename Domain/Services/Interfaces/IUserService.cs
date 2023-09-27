using Domain.Models;

namespace Domain.Services.Interfaces
{
    public interface IUserService
    {
        User GetUserById(int id);
    }
}
