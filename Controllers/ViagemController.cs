
using marcondes.Model;
using marcondes.Repository;
using Microsoft.AspNetCore.Mvc;

namespace marcondes.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ViagemController : ControllerBase
    {
        private readonly IViagemRepository _repository;

        public ViagemController(IViagemRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var clientes = await _repository.GetViagens();
            return clientes.Any() ? Ok(clientes) : NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var cliente = await _repository.GetViagemById(id);
            return cliente != null
            ? Ok(cliente) : NotFound("Viagem não encontrado.");
        }

        [HttpPost]
        public async Task<IActionResult> Post(Viagem cliente)
        {
            _repository.AddViagem(cliente);
            return await _repository.SaveChangesAsync()
            ? Ok("Viagem adicionada") : BadRequest("Algo deu errado.");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Atualizar(int id, Viagem viagem)
        {
            var viagemExiste = await _repository.GetViagemById(id);
            if (viagemExiste == null) return NotFound("Viagem não encontrada");

            viagemExiste.Destino = viagem.Destino ?? viagemExiste.Destino;
            viagemExiste.Origem = viagem.Origem ?? viagemExiste.Origem;
            viagemExiste.DataIdaVolta = viagem.DataIdaVolta ?? viagemExiste.DataIdaVolta;
            viagemExiste.Valor = viagem.Valor ?? viagemExiste.Valor;
           

            _repository.AtualizarViagem(viagemExiste);

            return await _repository.SaveChangesAsync()
            ? Ok("Viagem atualizada.") : BadRequest("Algo deu errado.");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var viagemExiste = await _repository.GetViagemById(id);
            if (viagemExiste == null)
                return NotFound("Viagem não encontrado");

            _repository.DeletarViagem(viagemExiste);

            return await _repository.SaveChangesAsync()
            ? Ok("Viagem deletado.") : BadRequest("Algo deu errado.");
        }
        
    }
}