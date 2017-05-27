using AutoMapper;
using VidlyThirdTime.Dtos;
using VidlyThirdTime.Models;

namespace VidlyThirdTime.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>().ForMember(c => c.Id, opt => opt.Ignore());

            //Moive
            Mapper.CreateMap<Movie, MoviesDto>();
            Mapper.CreateMap<MoviesDto, Movie>().ForMember(m => m.Id, opt => opt.Ignore())
                .ForMember(m => m.DateAdded, opt => opt.Ignore());
        }
    }
}