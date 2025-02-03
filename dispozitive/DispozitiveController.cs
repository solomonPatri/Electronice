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
        public async Task<ActionResult<ElectResponse>> CreateElectronics([FromBody] ElectRequest createElectRequest)
        {


            ElectResponse create = await _electRepo.CreateAsync(createElectRequest);



            return Created("", create);
        }

        [HttpDelete("delete/{id}")]

        public async Task<ActionResult<ElectResponse>> DeleteElec([FromRoute] int id)
        {

            ElectResponse response = await _electRepo.DeleteAsync(id);

            return Accepted("", response);



        }

        [HttpPut("edit/{id}")]

        public async Task<ActionResult<ElectResponse>>  EditElec([FromRoute] int id, [FromBody]ElectUpdateRequest update)
        {

            ElectResponse response = await _electRepo.UpdateAsync(id, update);

            return Accepted("",response);


        }























    }













}