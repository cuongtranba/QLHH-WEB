using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLHH.DAL.Model
{
    public class CompanyBrand : BaseEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CompanyBrandId { get; set; }
        [StringLength(50)]
        public string CompanyBrandName { get; set; }
        [StringLength(50)]
        public string Address { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string Fax { get; set; }
    }
}
