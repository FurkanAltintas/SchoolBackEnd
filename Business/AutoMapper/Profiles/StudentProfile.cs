using AutoMapper;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.AutoMapper.Profiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile()
        {
            CreateMap<StudentRegisterDto, Student>().ForMember(dest => dest.IsActive, opt => opt.MapFrom(x => true));
            CreateMap<TeacherRegisterDto, Teacher>().ForMember(dest => dest.IsActive, opt => opt.MapFrom(x => true));
        }
    }
}