using Microsoft.AspNetCore.Mvc;
using Packing3.Services;
using Packing3.Models;

namespace Packing3.Controllers
{
    [Route("api/[controller]/[action]")]
	[ApiController]
	public class Spro_ProdcuartelesController : ControllerBase
    {
        private readonly ISpro_ProdcuartelesService _ispro_prodcuartelesservice;

        public Spro_ProdcuartelesController(ISpro_ProdcuartelesService ispro_prodcuartelesservice)
        {
            _ispro_prodcuartelesservice = ispro_prodcuartelesservice;
        }

        //GET api/Spro_Prodcuarteles/RetrieveOne/{prod_codigo}
        [HttpGet("{prod_codigo}/{predio}/{cuartel}")]
        [ProducesResponseType(typeof(Spro_Prodcuarteles), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Spro_Prodcuarteles>> RetrieveOneAsync(decimal prod_codigo, decimal predio, decimal cuartel)
        {
            try
            {
                var result = await _ispro_prodcuartelesservice.RetrieveOneAsync(prod_codigo, predio, cuartel, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}