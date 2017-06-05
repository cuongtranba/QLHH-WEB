using System.ComponentModel.DataAnnotations;

namespace QLHH.DAL.Model
{
    public class EntityAttribute: BaseEntity
    {
        [Key]
        public int EntityAttributeId { get; set; }
        public int EntityId { get; set; }
        public int AttributeId { get; set; }
        [Required]
        public int Row { get; set; }
        [Required]
        public int Column { get; set; }
        [Required]
        public string EntityAttributeValue { get; set; }
        public virtual Entity Entity { get; set; }
        public virtual Attribute Attribute { get; set; }
    }
}
