using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLHH.DAL.Model
{
    public class Attribute : BaseEntity
    {
        public Attribute()
        {
            IsRequired = false;
            EntityAttributes = new List<EntityAttribute>();
        }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AttributeId { get; set; }
        [StringLength(50)]
        public string AttributeName { get; set; }
        [StringLength(50)]
        public string DataSourceUrl { get; set; }
        public int AttributeTypeId { get; set; }
        public virtual AttributeType AttributeType { get; set; }
        public bool IsRequired { get; set; }
        public virtual ICollection<EntityAttribute> EntityAttributes { get; set; }
    }
}
