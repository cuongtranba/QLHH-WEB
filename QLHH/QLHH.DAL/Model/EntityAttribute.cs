using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLHH.DAL.Model
{
    public class EntityAttribute: BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EntityAttributeId { get; set; }
        public int EntityId { get; set; }
        public int AttributeId { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        [Required]
        public string EntityAttributeValue { get; set; }
        public virtual Entity Entity { get; set; }
        public virtual Attribute Attribute { get; set; }
    }
}
