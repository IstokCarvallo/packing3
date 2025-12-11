using Microsoft.AspNetCore.Mvc;
using DWNet.Data;
using Packing3.Services;
using Packing3.Models;

namespace Packing3.Controllers
{
    [Route("api/[controller]/[action]")]
	[ApiController]
	public class CalibresEnvaseController : ControllerBase
    {
        private readonly ICalibresEnvaseService _icalibresenvaseservice;

        public CalibresEnvaseController(ICalibresEnvaseService icalibresenvaseservice)
        {
            _icalibresenvaseservice = icalibresenvaseservice;
        }
    
        //GET api/CalibresEnvase/Retrieve/{especie}/{tipo}/{codigo}
        [HttpGet("{especie}/{tipo}/{codigo}")]
        [ProducesResponseType(typeof(IDataStore<CalibresEnvase>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<CalibresEnvase>>> RetrieveAsync(double? especie, double? tipo, double? codigo)
        {
            try
            {
                var result = await _icalibresenvaseservice.RetrieveAsync(especie, tipo, codigo, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}