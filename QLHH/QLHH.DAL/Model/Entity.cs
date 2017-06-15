using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLHH.DAL.Model
{
    public class Entity : BaseEntity
    {
        public Entity()
        {
            EntityAttributes = new List<EntityAttribute>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EntityId { get; set; }
        public virtual List<EntityAttribute> EntityAttributes { get; set; }
        public virtual EntityType EntityType { get; set; }
        public int EntityTypeId { get; set; }
    }
}
