using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IStudentService
    {
        void Add(StudentRegisterDto studentRegisterDto);
        List<Student> GetList();
    }
}