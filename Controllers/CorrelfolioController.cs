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
	public class CorrelfolioController : ControllerBase
    {
        private readonly ICorrelfolioService _idw_mues_correlfolioservice;

        public CorrelfolioController(ICorrelfolioService idw_mues_correlfolioservice)
        {
            _idw_mues_correlfolioservice = idw_mues_correlfolioservice;
        }

        //GET api/Dw_Mues_Correlfolio/Retrieve/{Cliente}
        [HttpGet("{Cliente}")]
        [ProducesResponseType(typeof(IDataStore<Correlfolio>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Correlfolio>>> RetrieveAsync(double? Cliente)
        {
            try
            {
                var result = await _idw_mues_correlfolioservice.RetrieveAsync(Cliente, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}