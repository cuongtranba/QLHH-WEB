using System.ComponentModel.DataAnnotations;

namespace QLHH.DAL.Model
{
    public class Department:BaseEntity
    {
        [Key]
        public int DepartmentId { get; set; }
        [StringLength(50)]
        public string DepartmentName { get; set; }
        [StringLength(50)]
        public string Address { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string Fax { get; set; }
    }
}
