using AutoMapper;
using Business.Abstract;
using Core.Utilities.Hashing;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;

        public StudentManager(IStudentRepository studentRepository, IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public void Add(StudentRegisterDto studentRegisterDto)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(studentRegisterDto.Password, out passwordHash, out passwordSalt);
            #region AutoMapper kullanmadan
            //  Student student = new()
            //  {
            //     Name = studentRegisterDto.Name,
            //     Address = studentRegisterDto.Address,
            //     Gender = studentRegisterDto.Gender,
            //     IdentityNumber = studentRegisterDto.IdentityNumber,
            //     PaswordHash = passwordHash,
            //     PaswordSalt = passwordSalt,
            //     IsActive = true
            //  };
            #endregion
            var student = _mapper.Map<Student>(studentRegisterDto);
            student.PaswordHash = passwordHash;
            student.PaswordSalt = passwordSalt;
            _studentRepository.Add(student);
        }

        public List<Student> GetList()
        {
            var students = _studentRepository.GetList();
            return students;
        }
    }
}