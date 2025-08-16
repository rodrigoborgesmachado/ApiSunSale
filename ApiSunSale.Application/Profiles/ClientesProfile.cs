using Main = ApiSunSale.Domain.Entities.Clientes;
using MainDto = ApiSunSale.Application.DTO.ClientesDTO;

namespace ApiSunSale.Application.Profiles
{
    public class ClientesProfile : AutoMapper.Profile
    {
        public ClientesProfile()
        {
            CreateMap<Main, MainDto>().PreserveReferences();
            CreateMap<MainDto, Main>().PreserveReferences();
        }
    }
}
