using System;

namespace QLHH.DAL.Model
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            CreatedDate = DateTime.Now;
        }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
