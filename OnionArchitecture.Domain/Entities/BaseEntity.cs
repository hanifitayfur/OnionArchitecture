using System;

namespace OnionArchitecture.Domain.Entities
{
    public interface IBaseEntity<T>
    {
        public T Id { get; set; }
        public DateTime CreateDate { get; set; }
    }

    public class BaseEntity : IBaseEntity<int>
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
    }
}