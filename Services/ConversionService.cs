using UnitConversionApi.Models;
using UnitConversionApi.Services.Interfaces;

namespace UnitConversionApi.Services;

// Selects and executes appropriate converter
public class ConversionService : IConversionService
{
    private readonly IEnumerable<IUnitConverter> converters;

    public ConversionService(
        IEnumerable<IUnitConverter> converters)
    {
        this.converters = converters;
    }

    public ConversionResponse Convert(
        ConversionRequest request)
    {
        // Find converter for requested category
        var converter = converters.FirstOrDefault(
            c => c.Category.Equals(
                request.Category,
                StringComparison.OrdinalIgnoreCase));

        if (converter == null)
        {
            throw new ArgumentException(
                "Unsupported category");
        }

        // Perform conversion
        var result = converter.Convert(
            request.Value,
            request.FromUnit,
            request.ToUnit);

        return new ConversionResponse
        {
            OriginalValue = request.Value,
            FromUnit = request.FromUnit,
            ToUnit = request.ToUnit,
            ConvertedValue = result
        };
    }
}