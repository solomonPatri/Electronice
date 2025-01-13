using Electronice.Data;
using Electronice;
using Electronice.dispozitive.Service;
using Microsoft.AspNetCore.Mvc;
using Electronice.dispozitive.Model;

namespace Electronice.Data
{
    [ApiController]
    [Route("api/v1/[Controller]")]

    public class DispozitiveController : ControllerBase
    {
        private IElectrRepo _electRepo;

        public DispozitiveController(IElectrRepo electRepo)
        {
            this._electRepo = electRepo;


        }

        [HttpGet("all")]

        public async Task<ActionResult<IEnumerable<Electronic>>> GetAllAsync()
        {
            var electronics = await _electRepo.GetAllAsync();

            return Ok(electronics);


        }

        [HttpGet("Samsung")]

        public async Task<ActionResult<IEnumerable<Electronic>>> ElectronicsSamsung()
        {

            var electronics = await _electRepo.ElectronicsSamsung();

            return Ok(electronics);

        }
           















    }













}