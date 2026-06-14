# Unit Conversion API

A simple ASP.NET Core Web API for converting values between different measurement units.

# Supported Conversions

* Length

  * Meter
  * Kilometer
  * Centimeter
  * Foot
  * Inch

* Weight

  * Kilogram
  * Gram
  * Pound

* Temperature

  * Celsius
  * Fahrenheit
  * Kelvin

#  How to Run

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Build and run the project.
4. Open Swagger to test the API.

# Example Request

json
{
  "category": "Length",
  "fromUnit": "Meter",
  "toUnit": "Foot",
  "value": 10
}

