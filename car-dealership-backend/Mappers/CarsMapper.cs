using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using car_dealership_backend.Dtos.Cars;

namespace car_dealership_backend.Mappers
{
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
}