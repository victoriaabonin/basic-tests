using Application.Services;
using Domain.Models;
using Domain.Repositories.Repositories;
using Domain.Services.Interfaces;
using Moq;
using Xunit;

namespace UnitTests
{
    public class CarServiceUnitTests
    {
        [Fact]
        public void IsRenterAllowedToRentACar_UserIsAllowedToRent_ReturnsTrue()
        {
            // arrange
            var userService = new Mock<IUserService>();
            userService.Setup(x => x.GetUserById(1)).Returns(new User()
            {
                BirthDate = DateTime.Now.AddYears(-19)
            });

            var carRepository = new Mock<ICarRepository>();
            carRepository.Setup(x => x.GetCarById(1)).Returns(new Car()
            {
                MinimumDriverAgeAllowed = 18
            });

            var service = new CarService(carRepository.Object, userService.Object);

            // act
            var result = service.IsRenterAllowedToRentACar(1, 1);

            // assert
            Assert.True(result);
        }
    }
}
