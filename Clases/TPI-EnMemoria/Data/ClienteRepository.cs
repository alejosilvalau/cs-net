using Domain.Model;

namespace Data
{
    public class ClienteRepository : IClienteRepository
    {
        private static readonly List<Cliente> clientes = new List<Cliente>();
        private static int nextId = 1;

        public Task AddAsync(Cliente cliente)
        {
            // Simular auto-increment de ID
            cliente.SetId(nextId);
            nextId++;

            // Asignar navigation property del País
            var paisRepo = new PaisRepository();
            var pais = paisRepo.GetAllSync().FirstOrDefault(p => p.Id == cliente.PaisId);
            if (pais != null)
                cliente.SetPais(pais);

            clientes.Add(cliente);
            return Task.CompletedTask;
        }

        public Task<bool> DeleteAsync(int id)
        {
            var cliente = clientes.FirstOrDefault(c => c.Id == id);
            if (cliente != null)
            {
                clientes.Remove(cliente);
                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }

        public Task<Cliente?> GetAsync(int id)
        {
            return Task.FromResult(clientes.FirstOrDefault(c => c.Id == id));
        }

        public Task<IEnumerable<Cliente>> GetAllAsync()
        {
            return Task.FromResult<IEnumerable<Cliente>>(clientes.ToList());
        }

        public Task<bool> UpdateAsync(Cliente cliente)
        {
            var existing = clientes.FirstOrDefault(c => c.Id == cliente.Id);
            if (existing != null)
            {
                existing.SetNombre(cliente.Nombre);
                existing.SetApellido(cliente.Apellido);
                existing.SetEmail(cliente.Email);
                existing.SetPaisId(cliente.PaisId);

                // Actualizar navigation property del País
                var paisRepo = new PaisRepository();
                var pais = paisRepo.GetAllSync().FirstOrDefault(p => p.Id == cliente.PaisId);
                if (pais != null)
                    existing.SetPais(pais);

                return Task.FromResult(true);
            }
            return Task.FromResult(false);
        }

        public Task<bool> EmailExistsAsync(string email, int? excludeId = null)
        {
            var query = clientes.Where(c => c.Email.ToLower() == email.ToLower());
            if (excludeId.HasValue)
            {
                query = query.Where(c => c.Id != excludeId.Value);
            }
            return Task.FromResult(query.Any());
        }

        public Task<IEnumerable<Cliente>> GetByCriteriaAsync(ClienteCriteria criteria)
        {
            string searchTerm = criteria.Texto.ToLower();

            IEnumerable<Cliente> result = clientes.Where(c =>
                c.Nombre.ToLower().Contains(searchTerm) ||
                c.Apellido.ToLower().Contains(searchTerm) ||
                c.Email.ToLower().Contains(searchTerm)
            ).OrderBy(c => c.Nombre).ThenBy(c => c.Apellido).ToList();

            return Task.FromResult(result);
        }
    }
}
