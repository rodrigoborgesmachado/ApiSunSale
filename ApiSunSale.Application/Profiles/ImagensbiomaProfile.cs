using Main = ApiSunSale.Domain.Entities.Imagensbioma;
using MainDto = ApiSunSale.Application.DTO.ImagensbiomaDTO;

namespace ApiSunSale.Application.Profiles
{
    public class ImagensbiomaProfile : AutoMapper.Profile
    {
        public ImagensbiomaProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
