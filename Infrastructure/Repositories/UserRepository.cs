using Domain.Models;
using Domain.Repositories.Repositories;

namespace Infrastructure.Repositories
{
    internal class UserRepository : IUserRepository
    {
        public User GetUserById(int id)
        {
            return new User()
            {
                BirthDate = DateTime.Now.AddYears(-19)
            };
        }
    }
}
