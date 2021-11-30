using Application.Commands;
using Application.Interfaces;
using Application.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construdelas.BlueBank.Services.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class ContaController : ControllerBase
    {
        [HttpPost]
        public IActionResult Add([FromServices] AddContaCommand command, [FromBody] AddContaRequest request)
        {
            return Created("", command.Handle(request));
        }

        [HttpGet]
        public IActionResult Get([FromServices] IGetAllContaQuery query)
        {
            return Ok(query.Handle(new GetAllContaRequest()));
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromServices] IGetContaByIdQuery query, [FromRoute] Guid id)
        {
            var request = new GetContaByIdRequest() { Id = id };

            return Ok(query.Handle(request));
        }
    }

    
}
