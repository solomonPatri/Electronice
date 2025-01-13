using Electronice;
using Electronice.dispozitive.Model;

namespace Electronice.dispozitive.Service
{
    public interface IElectrRepo
    {
        Task<List<Electronic>> GetAllAsync();

        Task<List<Electronic>> ElectronicsSamsung();

        







    }
}
