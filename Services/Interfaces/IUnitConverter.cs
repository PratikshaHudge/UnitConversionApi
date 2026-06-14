namespace UnitConversionApi.Services.Interfaces;

// Contract for all unit converters
public interface IUnitConverter
{
    string Category { get; }

    double Convert(
        double value,
        string fromUnit,
        string toUnit);
}