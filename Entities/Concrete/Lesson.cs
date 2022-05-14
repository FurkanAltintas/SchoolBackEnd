using Core.Entities;

namespace Entities.Concrete
{
    public partial class Lesson : IEntity
    {       
        public int Id { get; set; }
        public string Name { get; set; }
    }
}