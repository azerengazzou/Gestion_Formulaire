using AutoMapper;
using backend.Models;
using backend.Models.DTO;
using backend.Models.DTO.Readonly;
using backend.Models.DTO.Update;

namespace backend.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<UserDTO,User>().ReverseMap();
            CreateMap<User,UserReadOnly>().ReverseMap();

            // CreateMap<User, UserReadOnly>().ForMember(q=>q.FormName,d=>d.MapFrom(map=>$"{map.Forms.First().NameForm}"))
            //   .ReverseMap();
            //CreateMap<User, UserUpdate>().ReverseMap();
            CreateMap<UserUpdate, User>().ReverseMap();

            CreateMap<FormDTO, Form>().ReverseMap();
            CreateMap<FormReadOnly,Form>().ReverseMap();
            CreateMap<FormUpdate, Form>().ReverseMap();
        }
    }
}
