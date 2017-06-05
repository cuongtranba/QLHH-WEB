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
        [StringLength(50)]
        public string EntityName { get; set; }
        public virtual ICollection<EntityAttribute> EntityAttributes { get; set; }
    }
}
