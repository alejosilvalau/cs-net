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

        public async Task<List<Alquiler>> GetAllAsync()
        {
            return await _context.Alquileres
                .OrderBy(x => x.FechaInicio)
                .ToListAsync();
        }

        public async Task<Alquiler> GetByIdAsync(int id)
        {
            Alquiler? alquiler = await _context.Alquileres.FindAsync(id);
            if (alquiler == null)
            {
                throw new Exception("Alquiler no encontrado.");
            }
            return alquiler;
        }

        public async Task<Alquiler> AddAsync(Alquiler alquiler)
        {
            _context.Alquileres.Add(alquiler);
            await _context.SaveChangesAsync();
            return alquiler;
        }

        public async Task<Alquiler> UpdateAsync(int id, Alquiler data)
        {
            Alquiler? alquiler = await _context.Alquileres.FindAsync(id);
            if (alquiler == null)
            {
                throw new Exception("Alquiler no encontrado.");
            }
            alquiler.Actualizar(data.Inquilino, data.MontoAlquiler, data.FechaInicio, data.FechaFin);
            await _context.SaveChangesAsync();
            return alquiler;
        }

        public async Task DeleteAsync(int id)
        {
            Alquiler? alquiler = await _context.Alquileres.FindAsync(id);
            if (alquiler == null)
            {
                throw new Exception("Alquiler no encontrado.");
            }
            _context.Alquileres.Remove(alquiler);
            await _context.SaveChangesAsync();
        }
    }
}
