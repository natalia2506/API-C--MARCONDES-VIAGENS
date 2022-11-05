using marcondes.Model;

namespace marcondes.Repository
{
    public interface IViagemRepository
    {
        Task<IEnumerable<Viagem>> GetViagens();
        Task<Viagem> GetViagemById(int id);
        void AddViagem(Viagem viagem);
        void AtualizarViagem(Viagem viagem);
        void DeletarViagem(Viagem viagem);
        Task<bool> SaveChangesAsync(); 
        
    }
}