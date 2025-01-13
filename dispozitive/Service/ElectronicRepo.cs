using Electronice;
using Electronice.dispozitive.Model;
using Electronice.Data;
using Microsoft.EntityFrameworkCore;

namespace Electronice.dispozitive.Service
{
    public class ElectronicRepo:IElectrRepo
    {
        private readonly AppDbContext _appDbContext;


        public ElectronicRepo(AppDbContext context)
        {
            this._appDbContext = context;



        }

        public async Task<List<Electronic>> GetAllAsync()
        {
            return await _appDbContext.Electronics.ToListAsync();


        }
        public async Task<List<Electronic>> ElectronicsSamsung()
        {

            return await _appDbContext.Electronics.Where(u => u.Model.Equals("Samsung"))
                .ToListAsync();

        }







    }
}
