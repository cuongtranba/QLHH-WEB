using System.ComponentModel.DataAnnotations;
namespace QLHH.DAL.Model
{
    public class AttributeType: BaseEntity
    {
        [Key]
        public int AttributeTypeId { get; set; }
        [StringLength(50)]
        public string AttributeTypeName { get; set; }
        [StringLength(50)]
        public string AttributeDefaultValue { get; set; }
    }
}
