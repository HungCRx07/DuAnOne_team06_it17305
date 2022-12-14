using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _1.dal.Table
{
    [Table("HoaDon")]
    public class HoaDon
    {
        [Key]
        public Guid id { get; set; }
        [Required]

        public Guid idNv { get; set; }
        [ForeignKey(nameof(idNv))]
        [InverseProperty(nameof(NhanVien.HoaDons))]
        public NhanVien nhanViens { get; set; }

        [StringLength(20)]
        public string ma { get; set; }
        public DateTime ngTao { get; set; }
        public DateTime ngThanhToan { get; set; }

        public ICollection<HoaDonCt> HoaDonCts { get; set; }
    }
}
