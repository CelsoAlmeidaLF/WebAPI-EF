using AutoMapper;
using Systekna.Core;
using Systekna.Core.DTOs;

namespace Systekna.Infrasctruture.Util
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles() 
        {
            CreateMap<EntityDespesaDTO, EntityDespesa>();
        }
    }
}
