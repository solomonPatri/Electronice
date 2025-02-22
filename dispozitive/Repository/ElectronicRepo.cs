using Electronice;
using Electronice.dispozitive.Model;
using Electronice.Data;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Electronice.dispozitive.Dtos;

namespace Electronice.dispozitive.Repository
{
    public class ElectronicRepo:IElectrRepo
    {
        private readonly AppDbContext _appDbContext;
        private readonly IMapper _mapper;

        public ElectronicRepo(AppDbContext context,IMapper mapper)
        {
            this._appDbContext = context;
            this._mapper = mapper;


        }

        public async Task<List<Electronic>> GetAllAsync()
        {
            return await _appDbContext.Electronics.ToListAsync();


        }
       

        public async Task<ElectResponse> CreateAsync(ElectRequest createElectResponse)
        {

            Electronic elect = _mapper.Map<Electronic>(createElectResponse);

            _appDbContext.Electronics.Add(elect);

            await _appDbContext.SaveChangesAsync();

            ElectResponse response  = _mapper.Map<ElectResponse>(elect);

            return response;



        }

        public async Task<ElectResponse> DeleteAsync(int id)
        {

            Electronic elect = await _appDbContext.Electronics.FindAsync(id);

            ElectResponse response = _mapper.Map<ElectResponse>(elect);


             _appDbContext.Remove(elect);

            await _appDbContext.SaveChangesAsync();
            return response;

        }

        public async Task<ElectResponse> UpdateAsync(int id , ElectUpdateRequest elec)
        {

            Electronic electronic = await _appDbContext.Electronics.FindAsync(id);

            if (elec.Dispozitiv != null)
            {
                electronic.Dispozitiv = elec.Dispozitiv;
            }

            if (elec.Model != null)
            {
                electronic.Model = elec.Model;

            }
            if (elec.Memory.HasValue)
            {
                electronic.Memory = elec.Memory.Value;
            }

            if (elec.Price.HasValue)
            {
                electronic.Price = elec.Price.Value;
            }

            _appDbContext.Electronics.Update(electronic);

            await _appDbContext.SaveChangesAsync();

            ElectResponse update = _mapper.Map<ElectResponse>(electronic);

            return update;





        }



        public async Task<ElectResponse> FindByDispozitivAsync(string name)
        {

            Electronic elec = await _appDbContext.Electronics.FirstOrDefaultAsync(e=>e.Dispozitiv.Equals(name));

            ElectResponse response = _mapper.Map<ElectResponse>(elec);

            return response;




        }


        public async Task<ElectResponse> FindByIdAsync(int id)
        {
            Electronic elec = await this._appDbContext.Electronics.FindAsync(id);

            ElectResponse response = _mapper.Map<ElectResponse>(elec);

            return response;



        }


        public async Task<GetAllNamesElecDto> GetAllElectronicsAsync()
        {

            List<string> dipsozi = await this._appDbContext.Electronics.Select(s => s.Dispozitiv).ToListAsync();

            GetAllNamesElecDto response = new GetAllNamesElecDto();

            response.Names = dipsozi;

            return response;


        }




















    }
}
