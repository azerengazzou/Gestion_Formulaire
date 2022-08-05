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

            // CreateMap<User, UserReadOnly>().ForMember(q=>q.FormName,d=>d.MapFrom(map=>$"{map.Forms.First().NameForm}"))
            //   .ReverseMap();
            //CreateMap<User, UserUpdate>().ReverseMap();


            CreateMap<User, UserReadOnly>().ReverseMap();
            CreateMap<UserDTO, User>().ReverseMap();
            CreateMap<UserUpdate, User>().ReverseMap();

            //form
            CreateMap<FormDTO, Form>().ReverseMap();
            CreateMap<Form, FormReadOnly>().ReverseMap();
            CreateMap<FormUpdate, Form>().ReverseMap();
            
            //many to many
            CreateMap<Cmp, CmpReadOnly>().ForMember(dto => dto.Form,opt=> opt.MapFrom(x => x.FormCmps.Select(y => y.IdFormNavigation).ToList())).ReverseMap();

            CreateMap<Detail, DetailsReadOnly>().ForMember(dto => dto.CmpDetails, opt => opt.MapFrom(x => x.CmpDetails.Select(y => y.IdDetailsNavigation).ToList()));

            //cmp
            CreateMap<CmpDTO, Cmp>().ReverseMap();
            CreateMap<Cmp, CmpReadOnly>().ReverseMap();
            CreateMap<CmpUpdate, Cmp>().ReverseMap();

            //details
            CreateMap<DetailsDTO, Detail>().ReverseMap();
            CreateMap<Detail, DetailsReadOnly>().ReverseMap();
        }
    }
}
