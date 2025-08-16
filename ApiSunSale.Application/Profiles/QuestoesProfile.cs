using Main = ApiSunSale.Domain.Entities.Questoes;
using MainDto = ApiSunSale.Application.DTO.QuestoesDTO;

namespace ApiSunSale.Application.Profiles
{
    public class QuestoesProfile : AutoMapper.Profile
    {
        public QuestoesProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
