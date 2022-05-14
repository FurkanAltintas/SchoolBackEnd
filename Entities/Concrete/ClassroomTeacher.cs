using Core.Entities;

namespace Entities.Concrete
{
    public partial class ClassroomTeacher : IEntity
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int ClassId { get; set; }
    }
}