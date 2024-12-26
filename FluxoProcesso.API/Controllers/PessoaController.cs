using FluxoProcesso.Application.Contracts;
using FluxoProcesso.Application.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace FluxoProcesso.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private readonly IPessoaService _pessoaService;

        public PessoaController(IPessoaService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        /// <summary>
        /// Consultar pessoa pelo Código
        /// </summary>
        /// <remarks></remarks>
        /// <param name="id">Id da pessoa</param>
        /// <returns>Pessoa selecionada</returns>
        /// <response code="200">Consultado com sucesso</response>
        /// <response code="400">Pessoa Não encontrado</response>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Get(int id)
        {
            try
            {
                PessoaDto entity = await _pessoaService.GetPessoaByIdAsync(id);

                return Ok(entity);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        /// <summary>
        /// Consultar todas as pessoas
        /// </summary>
        /// <remarks></remarks>
        /// <returns>Pessoa selecionada</returns>
        /// <response code="200">Consultado com sucesso</response>
        /// <response code="400">Pessoas Não encontradas</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Get()
        {
            try
            {
                ICollection<PessoaDto> result = await _pessoaService.GetAllPessoaAsync();
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

        /// <summary>
        /// Cadastrar Pessoa
        /// </summary>
        /// <remarks></remarks>
        /// <param name="dto">Dados da pessoa</param>
        /// <response code="204">Cadastrado com sucesso</response>
        /// <response code="400">Erro ao cadastrar a pessoa</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Post(PessoaDto dto)
        {
            try
            {
                await _pessoaService.CreatePessoaAsync(dto);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        /// <summary>
        /// Atualizar registro de pessoa
        /// </summary>
        /// <remarks></remarks>
        /// <param name="dto">Novos dados da pessoa</param>
        /// <response code="204">Atualizado com sucesso</response>
        /// <response code="400">Erro ao atualizar a pessoa</response>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Put(PessoaDto dto)
        {
            try
            {
                await _pessoaService.UpdatePessoaAsync(dto);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        /// <summary>
        /// Excluir pessoa
        /// </summary>
        /// <remarks></remarks>
        /// <param name="id">Id da pessoa</param>
        /// <response code="204">Deletado com sucesso</response>
        /// <response code="400">Erro ao excluir pessoa</response>
        [HttpDelete("id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _pessoaService.DeletePessoaAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
