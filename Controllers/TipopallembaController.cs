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
	public class TipopallembaController : ControllerBase
    {
        private readonly ITipopallembaService _itipopallembaservice;

        public TipopallembaController(ITipopallembaService itipopallembaservice)
        {
            _itipopallembaservice = itipopallembaservice;
        }

        //GET api/Tipopallemba/Retrieve/{cliente}/{embalaje}
        [HttpGet("{cliente}/{embalaje}")]
        [ProducesResponseType(typeof(IDataStore<Tipopallemba>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IDataStore<Tipopallemba>>> RetrieveAsync(double? cliente, string embalaje)
        {
            try
            {
                var result = await _itipopallembaservice.RetrieveAsync(cliente, embalaje, default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

    }
}