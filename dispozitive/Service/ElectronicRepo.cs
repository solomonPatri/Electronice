using Electronice;
using Electronice.dispozitive.Model;
using Electronice.Data;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Electronice.dispozitive.Dtos;

namespace Electronice.dispozitive.Service
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
       

        public async Task<CreateElectResponse> CreateElectronic(CreateElectRequest createElectResponse)
        {

            Electronic elect = _mapper.Map<Electronic>(createElectResponse);

            _appDbContext.Electronics.Add(elect);

            await _appDbContext.SaveChangesAsync();

            CreateElectResponse response  = _mapper.Map<CreateElectResponse>(elect);

            return response;





        }





    }
}
