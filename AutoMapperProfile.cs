using AutoMapper;

namespace HelloAutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<WeatherForecast, WeatherForecastDTO>();
            CreateMap<WeatherForecast, WeatherForecastDTO>().ReverseMap();

            CreateMap<Customer, CustomerDTO>();
            CreateMap<Customer, CustomerDTO>().ReverseMap();

            CreateMap<Customer, CustomerViewDTO>().IncludeMembers(c => c.Address);
            CreateMap<Customer, CustomerViewDTO>().IncludeMembers(c => c.Address).ReverseMap();
            CreateMap<Address, CustomerViewDTO>();
            CreateMap<Address, CustomerViewDTO>().ReverseMap();
            // CreateMap<Customer, CustomerViewDTO>().IncludeMembers(e => e.Address).ReverseMap();
        }
    }
}