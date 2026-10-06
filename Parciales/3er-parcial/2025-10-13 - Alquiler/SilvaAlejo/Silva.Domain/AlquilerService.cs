namespace Silva.Domain
{
    public class AlquilerService
    {
        private readonly AlquilerRepository _repository;

        public AlquilerService(AlquilerRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Alquiler>> GetByEstadoAsync(string estado)
        {
            if (estado != "Activo" && estado != "Finalizado")
            {
                throw new Exception("Estado inválido. Valores permitidos: Activo, Finalizado.");
            }
            return await _repository.GetByEstadoAsync(estado);
        }

        public async Task<Alquiler> AddAsync(Alquiler alquiler)
        {
            // El alquiler siempre se crea como Activo, sin importar lo que envíe el cliente.
            alquiler.Activar();
            AlquilerValidation.IsValid(alquiler);
            return await _repository.AddAsync(alquiler);
        }

        public async Task<Alquiler> FinalizarAsync(int id)
        {
            return await _repository.FinalizarAsync(id);
        }
    }
}
