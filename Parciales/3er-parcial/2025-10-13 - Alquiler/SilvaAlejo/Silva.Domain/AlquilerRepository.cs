using Microsoft.EntityFrameworkCore;

namespace Silva.Domain
{
    public class AlquilerRepository
    {
        private readonly AlquilerContext _context;

        public AlquilerRepository(AlquilerContext context)
        {
            _context = context;
        }

        public async Task<List<Alquiler>> GetByEstadoAsync(string estado)
        {
            return await _context.Alquileres
                .Where(x => x.Estado == estado)
                .OrderBy(x => x.FechaInicio)
                .ToListAsync();
        }

        public async Task<Alquiler> AddAsync(Alquiler alquiler)
        {
            _context.Alquileres.Add(alquiler);
            await _context.SaveChangesAsync();
            return alquiler;
        }

        public async Task<Alquiler> FinalizarAsync(int id)
        {
            Alquiler? alquiler = await _context.Alquileres.FindAsync(id);
            if (alquiler == null)
            {
                throw new Exception("Alquiler no encontrado.");
            }
            alquiler.Finalizar();
            await _context.SaveChangesAsync();
            return alquiler;
        }
    }
}
