using Electronice.dispozitive.Dtos;
using Electronice.dispozitive.Repository;
using Electronice.dispozitive.Exceptions;
using Electronice.dispozitive.Model;

namespace Electronice.dispozitive.Services
{
    public class CommandElecService:ICommandElecService
    {
        private readonly IElectrRepo _repo;

        public CommandElecService(IElectrRepo repo)
        {

            this._repo = repo;

        }


        public async Task<ElectResponse> CreateAsync(ElectRequest createResponse)
        {

            ElectResponse elec = await this._repo.FindByDispozitivAsync(createResponse.Dispozitiv);

            if (elec != null)
            {
                ElectResponse response = await this._repo.CreateAsync(createResponse);
                return response;
            }
            throw new ElecNotFoundException();



        }

       public async  Task<ElectResponse> DeleteAsync(int id)
        {
            ElectResponse elec = await this._repo.FindByIdAsync(id);
            if (elec != null)
            {

                ElectResponse response = await this._repo.DeleteAsync(id);
                return response;

            }


            throw new ElecNotFoundException();



        }

       public async  Task<ElectResponse> UpdateAsync(int id, ElectUpdateRequest elec)
        {
            ElectResponse e = await this._repo.FindByIdAsync(id);

            if(e != null)
            {
                if(e is ElectUpdateRequest)
                {
                    e.Dispozitiv = elec.Dispozitiv ?? e.Dispozitiv;

                    e.Model = elec.Model ?? e.Model;

                    e.Price = elec.Price ?? e.Price;

                    e.Memory     = elec.Memory ?? e.Memory;
                   

                    ElectResponse response = await this._repo.UpdateAsync(id, elec);

                    return response;

                }

                throw new ElecNotUpdateException();

            }

            throw new ElecNotFoundException();


        }















    }
}
