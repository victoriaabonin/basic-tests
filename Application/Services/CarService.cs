using Domain.Models;
using Domain.Repositories.Repositories;
using Domain.Services.Interfaces;

namespace Application.Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        private readonly IUserService _userService;

        public CarService(ICarRepository carRepository,
            IUserService userService)
        {
            _carRepository = carRepository;
            _userService = userService;
        }

        public Car GetCarById(int id)
        {
            return _carRepository.GetCarById(id);
        }

        public bool IsRenterAllowedToRentACar(int renterId, int carId)
        {
            var car = _carRepository.GetCarById(carId);
            var user = _userService.GetUserById(renterId);

            var userAge = Math.Floor((DateTime.Now - user.BirthDate).TotalDays / 365);

            return userAge >= car.MinimumDriverAgeAllowed;
        }
    }
}
