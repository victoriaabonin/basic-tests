using Domain.Models;

namespace Domain.Services.Interfaces
{
    public interface ICarService
    {
        Car GetCarById(int id);
        bool IsRenterAllowedToRentACar(int renterId, int carId);
    }
}
