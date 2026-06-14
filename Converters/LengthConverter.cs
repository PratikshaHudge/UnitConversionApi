using UnitConversionApi.Services.Interfaces;

namespace UnitConversionApi.Converters;

// Handles length conversions
public class LengthConverter : IUnitConverter
{
    public string Category => "Length";

    // Conversion factors relative to meter
    private readonly Dictionary<string, double> factors =
        new()
        {
            { "Meter", 1 },
            { "Kilometer", 1000 },
            { "Centimeter", 0.01 },
            { "Foot", 0.3048 },
            { "Inch", 0.0254 }
        };

    public double Convert(
        double value,
        string fromUnit,
        string toUnit)
    {
        // Convert source unit to meter
        double meters = value * factors[fromUnit];

        return meters / factors[toUnit];
    }
}