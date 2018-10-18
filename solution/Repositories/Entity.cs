using System;

namespace Repositories
{
    public abstract class Entity : IComparable<Entity>
    {
        public int Id { get; set;}

        public int CompareTo(Entity other)
        {
            return Id.CompareTo(other.Id);
        }
    }
}
