using AutoMapper;
using Business.Abstract;
using Core.Utilities.Hashing;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Concrete
{
    public class TeacherManager : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        private readonly IMapper _mapper;

        public TeacherManager(ITeacherRepository teacherRepository, IMapper mapper)
        {
            _teacherRepository = teacherRepository;
            _mapper = mapper;
        }

        public void Add(TeacherRegisterDto teacherRegisterDto)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(teacherRegisterDto.Password, out passwordHash, out passwordSalt);
            #region AutoMapper kullanmadan
            //  Teacher teacher = new()
            //  {
            //      Gender = teacherRegisterDto.Gender,
            //      Address = teacherRegisterDto.Address,
            //      IdentityNumber = teacherRegisterDto.IdentityNumber,
            //      IsActive = true,
            //      Name = teacherRegisterDto.Name,
            //      PaswordHash = passwordHash,
            //      PaswordSalt = passwordSalt
            //  };
            #endregion
            var teacher = _mapper.Map<Teacher>(teacherRegisterDto);
            teacher.PaswordHash = passwordHash;
            teacher.PaswordSalt = passwordSalt;
            _teacherRepository.Add(teacher);
        }

        public List<Teacher> GetList()
        {
            var results = _teacherRepository.GetList();
            return results;
        }
    }
}