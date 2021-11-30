using Application.Commands;
using Application.Interfaces;
using Application.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construdelas.BlueBank.Services.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        [HttpPost]
        public IActionResult Add([FromServices] AddClienteCommand command, [FromBody] AddClienteRequest request)
        {
            return Created("", command.Handle(request));
        }

        [HttpGet]
        public IActionResult Get([FromServices] IGetAllClienteQuery query)
        {
            return Ok(query.Handle(new GetAllClienteRequest()));
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromServices] IGetClienteByIdQuery query, [FromRoute] Guid id)
        {
            var request = new GetClienteByIdRequest() { Id = id };

            return Ok(query.Handle(request));
        }
    }
}
