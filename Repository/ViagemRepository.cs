using marcondes.DataBase;
using marcondes.Model;
using Microsoft.EntityFrameworkCore;

namespace marcondes.Repository
{
    public class ViagemRepository : IViagemRepository
    {
        private readonly ClienteDbContext _context;

        public ViagemRepository(ClienteDbContext context) { 
            _context = context;
        }

        public void AddViagem(Viagem viagem)
        {
            _context.Add(viagem);
        }

        public void AtualizarViagem(Viagem viagem)
        {
            _context.Update(viagem);
        }

        public void DeletarViagem(Viagem viagem)
        {
            _context.Remove(viagem);
        }

        public async Task<Viagem> GetViagemById(int id)
        {
            return await _context.Viagens
            .Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Viagem>> GetViagens()
        {
            return await _context.Viagens.ToListAsync();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
        
    }
}