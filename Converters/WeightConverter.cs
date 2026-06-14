using UnitConversionApi.Services.Interfaces;

namespace UnitConversionApi.Converters;

// Handles weight conversions
public class WeightConverter : IUnitConverter
{
    public string Category => "Weight";

    // Conversion factors relative to kilogram
    private readonly Dictionary<string, double> factors =
        new()
        {
            { "Kilogram", 1 },
            { "Gram", 0.001 },
            { "Pound", 0.453592 }
        };

    public double Convert(
        double value,
        string fromUnit,
        string toUnit)
    {
        // Convert source unit to kilogram
        double kilograms = value * factors[fromUnit];

        return kilograms / factors[toUnit];
    }
}