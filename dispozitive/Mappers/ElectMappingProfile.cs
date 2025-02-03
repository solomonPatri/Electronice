using AutoMapper;
using Electronice.dispozitive.Dtos;
using Electronice.dispozitive.Model;

namespace Electronice.dispozitive.Mappers
{
    public class ElectMappingProfile:Profile
    {

        public ElectMappingProfile()
        {

            CreateMap<ElectRequest, Electronic>();
            CreateMap<Electronic, ElectResponse>();
            CreateMap<ElectResponse, ElectUpdateRequest>();






        }





    }
}
