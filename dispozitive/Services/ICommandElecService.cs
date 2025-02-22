using Electronice.dispozitive.Dtos;

namespace Electronice.dispozitive.Services
{
    public interface ICommandElecService
    {


        Task<ElectResponse> CreateAsync(ElectRequest createResponse);

        Task<ElectResponse> DeleteAsync(int id);

        Task<ElectResponse> UpdateAsync(int id, ElectUpdateRequest elec);




    }
}
