using Electronice.Data;
using Electronice;
using Electronice.dispozitive.Service;
using Microsoft.AspNetCore.Mvc;
using Electronice.dispozitive.Model;
using Electronice.dispozitive.Dtos;

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

        [HttpPost("create")]
        public async Task<ActionResult<CreateElectResponse>> CreateElectronics([FromBody] CreateElectRequest createElectRequest)
        {


            CreateElectResponse create = await _electRepo.CreateElectronic(createElectRequest);



            return Created("", create);
        }








    }













}