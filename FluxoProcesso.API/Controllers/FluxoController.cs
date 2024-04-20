using FluxoProcesso.Application.Contracts;
using FluxoProcesso.Application.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace FluxoProcesso.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Consumes(contentType: "application/json")]
    public class FluxoController : ControllerBase
    {
        private readonly IFluxoService _fluxoService;

        public FluxoController(IFluxoService fluxoService)
        {
            _fluxoService = fluxoService;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                FluxoDto entity = await _fluxoService.GetFluxoByIdAsync(id);

                return Ok(entity);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Get()
        {
            try
            {
                ICollection<FluxoDto> result = await _fluxoService.GetAllFluxoAsync();
                if (result.Any())
                    return Ok(result);
                else
                    return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post(FluxoDto dto)
        {
            try
            {
                await _fluxoService.CreateFluxoAsync(dto);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Put(FluxoDto dto)
        {
            try
            {
                await _fluxoService.UpdateFluxoAsync(dto);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpDelete("id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _fluxoService.DeleteFluxoAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
