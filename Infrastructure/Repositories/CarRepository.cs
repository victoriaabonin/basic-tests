using Domain.Models;
using Domain.Repositories.Repositories;

namespace Infrastructure.Repositories
{
    public class CarRepository : ICarRepository
    {
        public Car GetCarById(int id)
        {
            return new Car()
            {
                MinimumDriverAgeAllowed = 18
            };
        }
    }
}
