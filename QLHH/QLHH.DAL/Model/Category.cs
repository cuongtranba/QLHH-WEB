using System.ComponentModel.DataAnnotations;

namespace QLHH.DAL.Model
{
    public class Category:BaseEntity
    {
        [Key]
        public int CategoryId { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
    }
}
