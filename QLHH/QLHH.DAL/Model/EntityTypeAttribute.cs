using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLHH.DAL.Model
{
    public class EntityTypeAttribute : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EntityTypeAttributeId { get; set; }
        public virtual EntityType EntityType { get; set; }
        public virtual Attribute Attribute { get; set; }
        public int AttributeId { get; set; }
        public int EntityTypeId { get; set; }

    }
}
