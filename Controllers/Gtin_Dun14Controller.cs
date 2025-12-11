using Microsoft.AspNetCore.Mvc;
using DWNet.Data;
using Packing3.Services;
using Packing3.Models;

namespace Packing3.Controllers
{
    [Route("api/[controller]/[action]")]
	[ApiController]
	public class Gtin_Dun14Controller : ControllerBase
    {
        private readonly IGtin_Dun14Service _igtin_dun14service;

        public Gtin_Dun14Controller(IGtin_Dun14Service igtin_dun14service)
        {
            _igtin_dun14service = igtin_dun14service;
        }

        //GET api/Gtin_Dun14/Retrieve/{cliente}/{embalaje}
        [HttpGet("{cliente}/{embalaje}")]
        [ProducesResponseType(typeof(IDataStore<Gtin_Dun14>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Gtin_Dun14>>> RetrieveAsync(double? cliente, string embalaje)
        {
            try
            {
                var result = await _igtin_dun14service.RetrieveAsync(cliente, embalaje, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}