using Core.Entities;

namespace Entities.Concrete
{
    public partial class ClassStudent : IEntity
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int StudentId { get; set; }
    }
}