using UnitConversionApi.Services.Interfaces;

namespace UnitConversionApi.Converters;

// Handles temperature conversions
public class TemperatureConverter : IUnitConverter
{
    public string Category => "Temperature";

    public double Convert(
        double value,
        string fromUnit,
        string toUnit)
    {
        if (fromUnit == toUnit)
            return value;

        // Convert source unit to Celsius
        double celsius = fromUnit switch
        {
            "Celsius" => value,
            "Fahrenheit" => (value - 32) * 5 / 9,
            "Kelvin" => value - 273.15,
            _ => throw new ArgumentException("Invalid unit")
        };

        // Convert Celsius to target unit
        return toUnit switch
        {
            "Celsius" => celsius,
            "Fahrenheit" => (celsius * 9 / 5) + 32,
            "Kelvin" => celsius + 273.15,
            _ => throw new ArgumentException("Invalid unit")
        };
    }
}