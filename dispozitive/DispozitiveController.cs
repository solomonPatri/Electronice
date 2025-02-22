using Electronice.Data;
using Electronice;
using Electronice.dispozitive.Services;
using Microsoft.AspNetCore.Mvc;
using Electronice.dispozitive.Model;
using Electronice.dispozitive.Dtos;
using Electronice.dispozitive.Services;
using Electronice.dispozitive.Exceptions;

namespace Electronice.Data
{
    [ApiController]
    [Route("api/v1/[Controller]")]

    public class DispozitiveController : ControllerBase
    {
        private readonly ICommandElecService _command;
        private readonly IQueryElecService _query;

        public DispozitiveController(ICommandElecService command,IQueryElecService query)
        {
            this._command = command;
            this._query = query;


        }

        [HttpGet("all")]

        public async Task<ActionResult<IEnumerable<Electronic>>> GetAllAsync()
        {
            try
            {
                var electronics = await _query.GetAllAsync();

                return Ok(electronics);
            }catch(ElecNotFoundException nf)
            {
                return NotFound(nf.Message);
            }


        }

        [HttpPost("create")]
        public async Task<ActionResult<ElectResponse>> CreateElectronics([FromBody] ElectRequest createElectRequest)
        {

            try {
                ElectResponse create = await _command.CreateAsync(createElectRequest);

                return Created("", create);

            }catch(ElecAlreadyExistException a)
            {
                return BadRequest(a.Message);
            }
        }
        [HttpDelete("delete/{id}")]

        public async Task<ActionResult<ElectResponse>> DeleteElec([FromRoute] int id)
        {
            try
            {
                ElectResponse response = await _command.DeleteAsync(id);

                return Accepted("", response);
            }catch(ElecNotFoundException nf)
            {
                return NotFound(nf.Message);
            }


        }

        [HttpPut("edit/{id}")]

        public async Task<ActionResult<ElectResponse>>  EditElec([FromRoute] int id, [FromBody]ElectUpdateRequest update)
        {
            try
            {
                ElectResponse response = await _command.UpdateAsync(id, update);

                return Accepted("", response);
            }catch(ElecNotUpdateException up)
            {
                return NotFound(up.Message);
            }catch(ElecNotFoundException nf)
            {
                return NotFound(nf.Message);
            }

        }

        [HttpGet("find/Dispozitiv/{disp}")]

        public async Task<ActionResult<ElectResponse>> GetByDispozitiveAsync([FromRoute] string disp)
        {

            try
            {
                ElectResponse response = await this._query.FindByDispozitivAsync(disp);
                return Accepted("",response);


            }
            catch(ElecNotFoundException nf)
            {
                return NotFound(nf.Message);
            }




        }

        [HttpGet("find/Id/{id}")]

        public async Task<ActionResult<ElectResponse>> GetByIdAsync([FromRoute] int id)
        {

            try {

                ElectResponse response = await this._query.FindByIdAsync(id);
                return Accepted("", response);
           
            
            }catch(ElecNotFoundException nf)
            {
                return NotFound(nf.Message);
            }



        }


        [HttpGet("GetAllDispozitive")]

        public async Task<ActionResult<GetAllNamesElecDto>> GetAllDispozitivAsync()
        {
            try
            {
                GetAllNamesElecDto response = await this._query.GetAllElectronicsAsync();
                return Ok(response);
            }
            catch (ElecNotFoundException nf)
            {
                return NotFound(nf.Message);
            }


        }










    }













}