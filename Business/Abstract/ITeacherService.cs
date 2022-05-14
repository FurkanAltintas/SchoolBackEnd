using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface ITeacherService
    {
        void Add(TeacherRegisterDto teacherRegisterDto);
        List<Teacher> GetList();
    }
}