using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLHH.DAL.Model
{
    public class Tax : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TaxId { get; set; }
        [StringLength(50)]
        public string TaxName { get; set; }
    }
}
