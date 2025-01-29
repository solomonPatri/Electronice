using Electronice;
using Electronice.dispozitive.Dtos;
using Electronice.dispozitive.Model;

namespace Electronice.dispozitive.Service
{
    public interface IElectrRepo
    {
        Task<List<Electronic>> GetAllAsync();

        Task<CreateElectResponse> CreateElectronic(CreateElectRequest createResponse);

        







    }
}
