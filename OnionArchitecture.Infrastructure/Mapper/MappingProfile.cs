using AutoMapper;

namespace OnionArchitecture.Infrastructure.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            AllowNullDestinationValues = true;
            AllowNullCollections = true;

            // CreateMap<Employee, EmployeeDto>()
            //     .ReverseMap();
        }
    }
}