using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Collections.Generic;
using DWNet.Data;
using Packing3.Services;
using System.Threading.Tasks;
using System.Threading;
using Packing3.Models;

namespace Packing3.Controllers
{
    [Route("api/[controller]/[action]")]
	[ApiController]
	public class ProdcuartelesController : ControllerBase
    {
        private readonly IProdcuartelesService _iprodcuartelesservice;

        public ProdcuartelesController(IProdcuartelesService iprodcuartelesservice)
        {
            _iprodcuartelesservice = iprodcuartelesservice;
        }
    
        //POST api/Prodcuarteles/Update
        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<int>> UpdateAsync([FromBody] IDataStore<Spro_Prodcuarteles> dataStore)
        {
            try
            {
                var result = await _iprodcuartelesservice.UpdateAsync(dataStore, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        //GET api/Prodcuarteles/RetrieveOne/{prod_codigo}/{prpr_codigo}/{prcc_codigo}/{siri_codigo}/{sico_codigo}
        [HttpGet("{prod_codigo}/{prpr_codigo}/{prcc_codigo}/{siri_codigo}/{sico_codigo}")]
        [ProducesResponseType(typeof(Spro_Prodcuarteles), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<Spro_Prodcuarteles>> RetrieveOneAsync(decimal prod_codigo, decimal prpr_codigo, decimal prcc_codigo, decimal? siri_codigo, decimal? sico_codigo)
        {
            try
            {
                var result = await _iprodcuartelesservice.RetrieveOneAsync(prod_codigo, prpr_codigo, prcc_codigo, siri_codigo, sico_codigo, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        //GET api/Prodcuarteles/Retrieve
        [HttpGet]
        [ProducesResponseType(typeof(IList<Spro_Prodcuarteles>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IList<Spro_Prodcuarteles>>> RetrieveAsync()
        {
            try
            {
                var result = await _iprodcuartelesservice.RetrieveAsync(default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        //POST api/Prodcuarteles/UpdateAsync1
        [HttpPost]
        [ActionName("UpdateAsync1")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<int>> UpdateAsync([FromBody] Spro_Prodcuarteles Spro_Prodcuarteles)
        {
            try
            {
                var result = await _iprodcuartelesservice.UpdateAsync(Spro_Prodcuarteles, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        //DELETE api/Prodcuarteles/Delete/{prod_codigo}/{prpr_codigo}/{prcc_codigo}/{siri_codigo}/{sico_codigo}
        [HttpDelete("{prod_codigo}/{prpr_codigo}/{prcc_codigo}/{siri_codigo}/{sico_codigo}")]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<int>> DeleteAsync(decimal prod_codigo, decimal prpr_codigo, decimal prcc_codigo, decimal? siri_codigo, decimal? sico_codigo)
        {
            try
            {
                var result = await _iprodcuartelesservice.DeleteAsync(prod_codigo, prpr_codigo, prcc_codigo, siri_codigo, sico_codigo, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}