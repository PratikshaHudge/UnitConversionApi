using UnitConversionApi.Models;

namespace UnitConversionApi.Services.Interfaces;

// Contract for conversion service
public interface IConversionService
{
    ConversionResponse Convert(
        ConversionRequest request);
}