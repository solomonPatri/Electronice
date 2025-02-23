using Electronice;
using Electronice.dispozitive.Dtos;
using Electronice.dispozitive.Model;

namespace Electronice.dispozitive.Repository
{
    public interface IElectrRepo
    {
        Task<GetAllElectrDto> GetAllAsync();

        Task<ElectResponse> CreateAsync(ElectRequest createResponse);

        Task<ElectResponse> DeleteAsync(int id);

        Task<ElectResponse> UpdateAsync(int id, ElectUpdateRequest elec);

        Task<GetAllElectrDto> FindByNameDispozAsync(string name);

        Task<ElectResponse> FindByIdAsync(int id);

        Task<GetAllNamesElecDto> GetAllElectronicsAsync();

        Task<ElectResponse> FindByDispozitivAsync(string name);




    }
}
