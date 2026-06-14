using UnitConversionApi.Converters;
using UnitConversionApi.Services;
using UnitConversionApi.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register application services
builder.Services.AddScoped<IConversionService, ConversionService>();

// Register supported converters
builder.Services.AddSingleton<IUnitConverter, LengthConverter>();
builder.Services.AddSingleton<IUnitConverter, WeightConverter>();
builder.Services.AddSingleton<IUnitConverter, TemperatureConverter>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();