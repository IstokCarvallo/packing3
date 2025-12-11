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
using Packing3.Services.Impl;

namespace Packing3.Controllers
{
    [Route("api/[controller]/[action]")]
	[ApiController]
	public class CodigoOperacionalController : ControllerBase
    {
        private readonly ICodigoOperacionalService _icodigooperacionalservice;

        public CodigoOperacionalController(ICodigoOperacionalService icodigooperacionalservice)
        {
            _icodigooperacionalservice = icodigooperacionalservice;
        }
        //GET api/CodigoOperacional/Retrieve
        [HttpGet]
        [ProducesResponseType(typeof(IList<CodigoOperacional>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IList<CodigoOperacional>>> RetrieveAsync()
        {
            try
            {
                var result = await _icodigooperacionalservice.RetrieveAsync(default);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}