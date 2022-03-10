using AutoMapper;
using caminhoes.Application.Commands;
using caminhoes.Application.Queries;
using caminhoes.Application.ViewModels;
using caminhoes.Domain.Interfaces.Mediatrs;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace caminhoes.WebApps.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaminhaoController : ControllerBase
    {
        private readonly IMediatrHandler _mediatr;
        private readonly IMapper _mapper;
        private readonly ICaminhaoQueries _CaminhaoQueries;
        public CaminhaoController(IMediatrHandler mediatr, IMapper mapper, ICaminhaoQueries CaminhaoQueries)
        {
            _mediatr = mediatr;
            _mapper = mapper;
            _CaminhaoQueries = CaminhaoQueries;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CaminhaoViewModel CaminhaoViewModel)
        {
            var command = _mapper.Map<CaminhaoCommand>(CaminhaoViewModel);
            var sucesso = await _mediatr.EnviarComando(command);

            if (!sucesso) return BadRequest();

            return CreatedAtAction(nameof(ObterPorId), new { Id = command.AggregateRoot }, new { Id = command.AggregateRoot, Display = command.Modelo });
        }

        [HttpGet]
        public async Task<IActionResult> ObterTodos()
        {
            var Caminhaos = await _CaminhaoQueries.ObterTodos();
            return Ok(Caminhaos);
        }

        [HttpGet("{id:Guid}")]
        public async Task<IActionResult> ObterPorId(Guid id)
        {
            var Caminhao = await _CaminhaoQueries.ObterPorId(id);
            return Ok(Caminhao);
        }
    }
}
