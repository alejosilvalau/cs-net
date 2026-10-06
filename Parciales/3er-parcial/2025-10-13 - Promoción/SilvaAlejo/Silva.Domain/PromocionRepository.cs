using Microsoft.EntityFrameworkCore;

namespace Silva.Domain
{
    public class PromocionRepository
    {
        public async Task<List<Promocion>> GetByEstadoAsync(string estado)
        {
            using var context = new PromocionContext();
            return await context.Promociones
                .Where(x => x.Estado == estado)
                .OrderBy(x => x.FechaInicio)
                .ToListAsync();
        }

        public async Task<Promocion?> GetByIdAsync(int id)
        {
            using var context = new PromocionContext();
            return await context.Promociones.FindAsync(id);
        }

        public async Task<Promocion> AddAsync(Promocion promocion)
        {
            using var context = new PromocionContext();
            context.Promociones.Add(promocion);
            await context.SaveChangesAsync();
            return promocion;
        }

        public async Task<Promocion> ExpirarAsync(int id)
        {
            using var context = new PromocionContext();
            Promocion? promocion = await context.Promociones.FindAsync(id);
            if (promocion == null)
            {
                throw new Exception("Promoción no encontrada.");
            }
            promocion.Estado = "Expirada";
            await context.SaveChangesAsync();
            return promocion;
        }
    }
}
