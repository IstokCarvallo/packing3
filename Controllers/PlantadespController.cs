using Microsoft.AspNetCore.Mvc;
using Packing3.Services;
using Packing3.Models;

namespace Packing3.Controllers
{
    [Route("api/[controller]/[action]")]
	[ApiController]
	public class PlantadespController : ControllerBase
    {
        private readonly IPlantadespService _iplantadespservice;

        public PlantadespController(IPlantadespService iplantadespservice)
        {
            _iplantadespservice = iplantadespservice;
        }
        //GET api/Plantadesp/RetrieveOne/{plde_codigo}
        [HttpGet("{plde_codigo}")]
        [ProducesResponseType(typeof(Plantadesp), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Plantadesp>> RetrieveOneAsync(decimal plde_codigo)
        {
            try
            {
                var result = await _iplantadespservice.RetrieveOneAsync(plde_codigo, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}