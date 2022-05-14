using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Concrete
{
    public class LessonManager : ILessonService
    {
        private readonly ILessonRepository _lessonRepository;

        public LessonManager(ILessonRepository lessonRepository)
        {
            _lessonRepository = lessonRepository;
        }

        public Result Add(Lesson lesson)
        {
            Result result = new()
            {
                Message = "Ders kaydı başarıyla tamamlandı.",
                Success = true
            };
            _lessonRepository.Add(lesson);
            return result;
        }

        public void Delete(int id)
        {
            var lesson = GetById(id);
            _lessonRepository.Delete(lesson.Data);
        }

        public DataResult<Lesson> GetById(int id)
        {
            var lesson =  _lessonRepository.Get(l => l.Id == id);
            DataResult<Lesson> dataResult = new()
            {
                Data = lesson,
                Message = "Derse ait kayıt başarıyla getirildi.",
                Success = true
            };
            return dataResult;
        }

        public DataResult<List<Lesson>> GetList()
        {
            var lessons =  _lessonRepository.GetList();
            DataResult<List<Lesson>> dataResult = new()
            {
                Data = lessons,
                Message = "Ders listesi başarıyla getirildi.",
                Success = true
            };
            return dataResult;
        }

        public void Update(Lesson lesson)
        {
            _lessonRepository.Update(lesson);
        }
    }
}