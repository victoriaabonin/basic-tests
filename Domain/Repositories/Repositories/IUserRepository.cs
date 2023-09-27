using Domain.Models;

namespace Domain.Repositories.Repositories
{
    public interface IUserRepository
    {
        User GetUserById(int id);
    }
}
