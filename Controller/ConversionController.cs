using Microsoft.AspNetCore.Mvc;
using UnitConversionApi.Models;
using UnitConversionApi.Services.Interfaces;

namespace UnitConversionApi.Controllers;

// API endpoint for unit conversion
[ApiController]
[Route("api/[controller]")]
public class ConversionController : ControllerBase
{
    private readonly IConversionService conversionService;

    public ConversionController(
        IConversionService conversionService)
    {
        this.conversionService = conversionService;
    }

    // Converts value between supported units
    [HttpPost("convert")]
    public IActionResult Convert(
        ConversionRequest request)
    {
        try
        {
            var result =
                conversionService.Convert(request);

            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(new
            {
                Message = ex.Message
            });
        }
    }
}