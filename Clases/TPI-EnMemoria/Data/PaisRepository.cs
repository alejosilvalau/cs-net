using Domain.Model;

namespace Data
{
    public class PaisRepository : IPaisRepository
    {
        private static readonly List<Pais> paises = new List<Pais>
        {
            new Pais(1, "Argentina"),
            new Pais(2, "Brasil"),
            new Pais(3, "Chile"),
            new Pais(4, "Uruguay"),
            new Pais(5, "Paraguay")
        };

        public Task<IEnumerable<Pais>> GetAllAsync()
        {
            return Task.FromResult<IEnumerable<Pais>>(paises.OrderBy(p => p.Nombre).ToList());
        }

        // Método interno sincrónico para uso desde ClienteRepository
        internal IEnumerable<Pais> GetAllSync()
        {
            return paises.OrderBy(p => p.Nombre).ToList();
        }
    }
}
