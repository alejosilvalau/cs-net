namespace Silva.Domain
{
    public class PromocionService
    {
        private readonly PromocionRepository _repository = new PromocionRepository();

        public async Task<List<Promocion>> GetByEstadoAsync(string estado)
        {
            if (estado != "Activa" && estado != "Expirada")
            {
                throw new Exception("Estado inválido. Valores permitidos: Activa, Expirada.");
            }
            return await _repository.GetByEstadoAsync(estado);
        }

        public async Task<Promocion> AddAsync(Promocion promocion)
        {
            // La promoción siempre se crea como Activa, sin importar lo que envíe el cliente.
            promocion.Estado = "Activa";
            PromocionValidation.IsValid(promocion);
            return await _repository.AddAsync(promocion);
        }

        public async Task<Promocion> ExpirarAsync(int id)
        {
            return await _repository.ExpirarAsync(id);
        }
    }
}
