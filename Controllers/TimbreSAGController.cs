using Microsoft.AspNetCore.Mvc;
using Packing3.Services;
using Packing3.Models;

namespace Packing3.Controllers
{
    [Route("api/[controller]/[action]")]
	[ApiController]
	public class TimbreSAGController : ControllerBase
    {
        private readonly ITimbreSAGService _itimbresagservice;

        public TimbreSAGController(ITimbreSAGService itimbresagservice)
        {
            _itimbresagservice = itimbresagservice;
        }
        //GET api/TimbreSAG/Retrieve
        [HttpGet]
        [ProducesResponseType(typeof(IList<TimbreSAG>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IList<TimbreSAG>>> RetrieveAsync()
        {
            try
            {
                var result = await _itimbresagservice.RetrieveAsync(default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}