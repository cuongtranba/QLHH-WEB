using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLHH.DAL.Model
{
    public class CategoryDetail : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryDetailId { get; set; }
        public string CategoryDetailName { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
