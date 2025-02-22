using Electronice.dispozitive.Dtos;
using Electronice.dispozitive.Model;
namespace Electronice.dispozitive.Services
{
    public interface IQueryElecService
    {

        Task<List<Electronic>> GetAllAsync();
        Task<ElectResponse> FindByDispozitivAsync(string name);

        Task<ElectResponse> FindByIdAsync(int id);

        Task<GetAllNamesElecDto> GetAllElectronicsAsync();









    }
}
