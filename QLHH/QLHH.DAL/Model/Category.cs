using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace QLHH.DAL.Model
{
    public class Category : BaseEntity
    {
        public Category()
        {
            CategoryDetails = new List<CategoryDetail>();
        }
        [Key]
        public int CategoryId { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
        public string Detail { get; set; }
        public virtual ICollection<CategoryDetail> CategoryDetails { get; set; }
    }
}
