using Core.Entities;

namespace Entities.Concrete
{
    public partial class ClassroomLesson : IEntity
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int LessonsId { get; set; }
    }
}