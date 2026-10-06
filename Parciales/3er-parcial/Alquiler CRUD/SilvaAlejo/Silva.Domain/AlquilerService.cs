namespace Silva.Domain
{
    public class AlquilerService
    {
        private readonly AlquilerRepository _repository;

        public AlquilerService(AlquilerRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Alquiler>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Alquiler> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Alquiler> AddAsync(Alquiler alquiler)
        {
            AlquilerValidation.IsValid(alquiler);
            return await _repository.AddAsync(alquiler);
        }

        public async Task<Alquiler> UpdateAsync(int id, Alquiler alquiler)
        {
            AlquilerValidation.IsValid(alquiler);
            return await _repository.UpdateAsync(id, alquiler);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
