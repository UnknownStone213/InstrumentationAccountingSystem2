using AutoMapper;
using InstrumentationAccountingSystem2.Dto;

namespace InstrumentationAccountingSystem2.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<UserCreateDto, User>();
            CreateMap<TypeCreateDto, Models.Type>();
            CreateMap<LocationCreateDto, Location>();
            CreateMap<InstrumentationCreateDto, Instrumentation>();
            CreateMap<VerificationCreateDto, Verification>();
            //CreateMap<UserLogInDto, User>();
            //CreateMap<NoteCreateDto, Note>();
        }
    }
}
