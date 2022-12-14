using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace VNUA.FITA.MQTT.HRM.Data.Model
{
    /// <summary>
    /// Nguyễn Đình Thuyết - K64CNPM - 646372
    /// </summary>
    [Table("NhanVien")]
    public class NhanVien
    {
        [Key]
        [StringLength(20)]
        public string MaNhanVien { get; set; }

        [StringLength(100)]
        public string HoTen { get; set; }

        [StringLength(20)]
        public string TenTaiKhoan { get; set; }

        public DateTime NgaySinh { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; }

        [StringLength(100)]
        public string DiaChi { get; set; }

        [StringLength(12)]
        public string SDT { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(20)]
        public string MatKhau { get; set; }

        public int PhanLoai { get; set; }

        [StringLength(100)]
        public string ChucVu { get; set; }

        [StringLength(100)]
        public string HangXe { get; set; }

        [StringLength(100)]
        public string MauXe { get; set; }

        [StringLength(12)]
        public string BienSoXe { get; set; }
        public byte Anh { get; set; }

        [StringLength(12)]
        public string SoCCCD { get; set; }

        [StringLength(10)]
        public string MaBP { get; set; }

        public int MaLLV { get; set; }

        public int MaBaoHiem { get; set; }

        [ForeignKey("MaBP")]
        public BoPhan BoPhans { get; set; }
        [ForeignKey("MaLLV")]
        public LichLamViec LichLamViecs { get; set; }
        [ForeignKey("MaBaoHiem")]
        public BaoHiem BaoHiems { get; set; }

        public IList<Luong> Luongs { get; set; }
        public IList<HopDong> HopDongs { get; set; }
        public IList<NgayCong> NgayCongs { get; set; }

        public IList<GiayTo> GiayTos { get; set; }
        public IList<BaiViet> BaiViets { get; set; }
        public IList<DonTu> DonTus { get; set; }
 

    }
}
