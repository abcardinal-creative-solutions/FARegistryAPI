
using AutoMapper;
using FARegistryAPI.DTO;
using FARegistryAPI.Models;


namespace FARegistryAPI.Profiles
{
    public class FARegistryProfile : Profile

    {
        public FARegistryProfile()
        {
            CreateMap<RegistryRecord, RegistryReadDTO>();
            CreateMap<RegistryWriteDTO, RegistryRecord>();
            CreateMap<RegistryUpdateDTO, RegistryRecord>();
            CreateMap<RegistryRecord, RegistryUpdateDTO>();
        }
        
        
        
    }
}
