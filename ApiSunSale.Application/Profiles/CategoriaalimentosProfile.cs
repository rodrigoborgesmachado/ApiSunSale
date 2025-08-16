using Main = ApiSunSale.Domain.Entities.Categoriaalimentos;
using MainDto = ApiSunSale.Application.DTO.CategoriaalimentosDTO;

namespace ApiSunSale.Application.Profiles
{
    public class CategoriaalimentosProfile : AutoMapper.Profile
    {
        public CategoriaalimentosProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
