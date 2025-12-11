using Microsoft.AspNetCore.Mvc;
using Packing3.Services;

namespace Packing3.Controllers
{
    [Route("api/[controller]/[action]")]
	[ApiController]
	public class EmbalajesprodController : ControllerBase
    {
        private readonly IEmbalajesprodService _iembalajesprodservice;

        public EmbalajesprodController(IEmbalajesprodService iembalajesprodservice)
        {
            _iembalajesprodservice = iembalajesprodservice;
        }

        //GET api/Embalajesprod/RetrieveOne/{emba_codigo}/{clie_codigo}/{copa_codigo}
        [HttpGet("{emba_codigo}/{clie_codigo}")]
        [ProducesResponseType(typeof(Embalajesprod), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Embalajesprod>> RetrieveOneAsync(string emba_codigo, decimal clie_codigo)
        {
            try
            {
                var result = await _iembalajesprodservice.RetrieveOneAsync(emba_codigo, clie_codigo, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}