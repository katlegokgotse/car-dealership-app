using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using car_dealership_backend.Dtos;
using car_dealership_backend.Dtos.Cars;

namespace car_dealership_backend.Mappers
{
    public static class CarsMapper
    {
        public static CarModelDto CarFromDto(this CarModels carModels)
        {
            return new CarModelDto
            {
                CarId = carModels.CarId,
                CarMake = carModels.CarMake,
                CarModel = carModels.CarModel,
                CarPrice = carModels.CarPrice,
                CarYear = carModels.CarYear,
                CarColour = carModels.CarColour,
                CarState = carModels.CarState,
                CarImage = carModels.CarImage,
                CarExtras = carModels.CarExtras,
                CarAdvertisementState = carModels.CarAdvertisementState
            };
        }
        public static CarModels ToCreateCarFromCreateDto(this CreateCarRequestDto createCarRequestDto)
        {
            return new CarModels
            {
                CarMake = createCarRequestDto.CarMake,
                CarModel = createCarRequestDto.CarModel,
                CarPrice = createCarRequestDto.CarPrice,
                CarYear = createCarRequestDto.CarYear,
                CarColour = createCarRequestDto.CarColour,
                CarState = createCarRequestDto.CarState,
                CarImage = createCarRequestDto.CarImage,
                CarExtras = createCarRequestDto.CarExtras,
                CarAdvertisementState = createCarRequestDto.CarAdvertisementState
            };
        }
        public static CarModels ToUpdateCarFromCarDto(this UpdateCarDto updateCarDto)
        {
            return new CarModels
            {
                CarMake = updateCarDto.CarMake,
                CarModel = updateCarDto.CarModel,
                CarPrice = updateCarDto.CarPrice,
                CarYear = updateCarDto.CarYear,
                CarColour = updateCarDto.CarColour,
                CarState = updateCarDto.CarState,
                CarImage = updateCarDto.CarImage,
                CarExtras = updateCarDto.CarExtras,
                CarAdvertisementState = updateCarDto.CarAdvertisementState
            }
        }
    }

}