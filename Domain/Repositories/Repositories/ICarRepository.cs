using Domain.Models;

namespace Domain.Repositories.Repositories
{
    public interface ICarRepository
    {
        Car GetCarById(int id);
    }
}
