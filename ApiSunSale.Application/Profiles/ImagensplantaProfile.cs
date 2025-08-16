using Main = ApiSunSale.Domain.Entities.Imagensplanta;
using MainDto = ApiSunSale.Application.DTO.ImagensplantaDTO;

namespace ApiSunSale.Application.Profiles
{
    public class ImagensplantaProfile : AutoMapper.Profile
    {
        public ImagensplantaProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
