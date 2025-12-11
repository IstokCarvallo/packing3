using Microsoft.AspNetCore.Mvc;
using Packing3.Services;
using Packing3.Models;

namespace Packing3.Controllers
{
    [Route("api/[controller]/[action]")]
	[ApiController]
	public class Spro_TimbresdespachoController : ControllerBase
    {
        private readonly ISpro_TimbresdespachoService _ispro_timbresdespachoservice;

        public Spro_TimbresdespachoController(ISpro_TimbresdespachoService ispro_timbresdespachoservice)
        {
            _ispro_timbresdespachoservice = ispro_timbresdespachoservice;
        }
        //GET api/Spro_Timbresdespacho/Retrieve
        [HttpGet]
        [ProducesResponseType(typeof(IList<Spro_Timbresdespacho>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IList<Spro_Timbresdespacho>>> RetrieveAsync()
        {
            try
            {
                var result = await _ispro_timbresdespachoservice.RetrieveAsync(default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}