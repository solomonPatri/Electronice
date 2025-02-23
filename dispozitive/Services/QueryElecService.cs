using Electronice.dispozitive.Dtos;
using Electronice.dispozitive.Exceptions;
using Electronice.dispozitive.Repository;
using Electronice.dispozitive.Model;
namespace Electronice.dispozitive.Services
{
    public class QueryElecService : IQueryElecService
    {
        private readonly IElectrRepo _repo;

        public QueryElecService(IElectrRepo repo)
        {
            this._repo = repo;


        }


        public async Task<GetAllElectrDto> GetAllAsync()
        {
            GetAllElectrDto response = await this._repo.GetAllAsync();
            if (response != null)
            {
                return response;

            }
            throw new ElecNotFoundException();


        }

        public async Task<GetAllElectrDto> FindByNameDispozAsync(string name)
        {
            GetAllElectrDto response = await this._repo.FindByNameDispozAsync(name);
            if(response != null)
            {

                return response;


            }
            throw new ElecNotFoundException();


        }



        public async Task<ElectResponse> FindByDispozitivAsync(string name)
        {
            ElectResponse response = await this._repo.FindByDispozitivAsync(name);

            if(response != null)
            {

                return response;


            }

            throw new ElecNotFoundException();



        }

       public async  Task<ElectResponse> FindByIdAsync(int id)
        {

            ElectResponse response = await this._repo.FindByIdAsync(id);

            if (response != null)
            {
                return response;

            }
            throw new ElecNotFoundException();


        }

       public async  Task<GetAllNamesElecDto> GetAllElectronicsAsync()
        {

            GetAllNamesElecDto response = await this._repo.GetAllElectronicsAsync();

                if(response != null)
            {

                return response;
            }
            throw new ElecNotFoundException();






        }











    }
}
