using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLHH.DAL.Model
{
    public class EntityType : BaseEntity
    {
        public EntityType()
        {
            Entities = new List<Entity>();
            EntityTypeAttributes = new List<EntityTypeAttribute>();
        }
        [Key]
        public int EntityTypeId { get; set; }
        [MaxLength(50)]
        public string EntityTypeName { get; set; }
        public virtual ICollection<Entity> Entities { get; set; }
        public virtual ICollection<EntityTypeAttribute> EntityTypeAttributes { get; set; }
    }
}
