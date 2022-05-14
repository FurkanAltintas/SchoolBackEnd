using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface ILessonService
    {
        Result Add(Lesson lesson);
        void Update(Lesson lesson);
        void Delete(int id);
        DataResult<List<Lesson>> GetList();
        DataResult<Lesson> GetById(int id);
    }
}