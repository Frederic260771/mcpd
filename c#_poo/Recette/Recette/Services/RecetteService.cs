using Recette.DTOs;
using Recette.Repository;

namespace Recette.Services
{
    public class RecetteService
    {

        private readonly RecetteRepository _repo;

        public RecetteService(RecetteRepository repo)
        {
            _repo = repo;
        }

        public List<RecetteShortDto> GetAll()
        {
            return _repo.GetAll()
                .Select(static r => new RecetteShortDto
                {
                    Id = r.Id,
                    Nom = r.Nom,
                }).ToList();








        }

        internal string? GetDetail(int id)
        {
            throw new NotImplementedException();
        }
    }
