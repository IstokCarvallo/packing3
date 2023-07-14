using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Collections.Generic;
using Packing3.Services;
using System.Threading.Tasks;
using System.Threading;
using Packing3;
using Microsoft.AspNetCore.Authorization;

namespace Packing3.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class EnvasesController : ControllerBase
	{
		private readonly IEnvasesService _ienvasesservice;

		public EnvasesController(IEnvasesService ienvasesservice)
		{
			_ienvasesservice = ienvasesservice;
		}

		//GET api/Envases/RetrieveOne/{enva_tipoen}/{enva_codigo}
		[HttpGet("{enva_tipoen}/{enva_codigo}")]
		[ProducesResponseType(typeof(Envases), StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public async Task<ActionResult<Envases>> RetrieveOneAsync(decimal enva_tipoen, decimal enva_codigo)
		{
			try
			{
				var result = await _ienvasesservice.RetrieveOneAsync(enva_tipoen, enva_codigo, default);
				return Ok(result);
			}
			catch (Exception ex)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
			}
		}
	}
}