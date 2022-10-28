﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VNUA.FITA.MQTT.HRM.Data.Access;

namespace VNUA.FITA.MQTT.HRM.Data.Access.Data.Migrations.SqlServer
{
    [DbContext(typeof(SQLServerDbContext))]
    partial class SQLServerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.BaiViet", b =>
                {
                    b.Property<int>("MaBaiViet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaNhanVien")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<DateTime>("ThoiGian")
                        .HasColumnType("datetime2");

                    b.Property<string>("TieuDe")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("MaBaiViet");

                    b.HasIndex("MaNhanVien");

                    b.ToTable("BaiViet");
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.BaoHiem", b =>
                {
                    b.Property<int>("MaBaoHiem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("ChiPhi")
                        .HasColumnType("float");

                    b.Property<string>("DonViCungCap")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("NoiDungBH")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<string>("TenBaoHiem")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("ThoiGianBD")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ThoiGianKT")
                        .HasColumnType("datetime2");

                    b.HasKey("MaBaoHiem");

                    b.ToTable("BaoHiem");
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.BoPhan", b =>
                {
                    b.Property<string>("MaBP")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("MaP")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("TenBP")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("MaBP");

                    b.HasIndex("MaP");

                    b.ToTable("BoPhan");
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.DonTu", b =>
                {
                    b.Property<int>("MaDonTu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("MaNhanVien")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("NguoiNhan")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("NoiDung")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("PhanLoai")
                        .HasColumnType("int");

                    b.Property<string>("TieuDe")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("TrangThai")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("MaDonTu");

                    b.HasIndex("MaNhanVien");

                    b.ToTable("DonTu");
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.GiayTo", b =>
                {
                    b.Property<int>("MaGT")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Anh")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("MaNhanVien")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("TenGT")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("MaGT");

                    b.HasIndex("MaNhanVien");

                    b.ToTable("GiayTo");
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.HopDong", b =>
                {
                    b.Property<long>("SoHD")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaNhanVien")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("NoiDungHD")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int>("PhanLoai")
                        .HasColumnType("int");

                    b.Property<string>("TenHD")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("ThoiGianBD")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ThoiGianKT")
                        .HasColumnType("datetime2");

                    b.Property<string>("TrangThai")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("SoHD");

                    b.HasIndex("MaNhanVien");

                    b.ToTable("HopDong");
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.LichLamViec", b =>
                {
                    b.Property<int>("MaLLV")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ChieuBD")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ChieuKT")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SangBD")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SangKT")
                        .HasColumnType("datetime2");

                    b.HasKey("MaLLV");

                    b.ToTable("LichLamViec");
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.Luong", b =>
                {
                    b.Property<int>("MaLuong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HeSo")
                        .HasColumnType("int");

                    b.Property<double>("LCoBan")
                        .HasColumnType("float");

                    b.Property<double>("LThucNhan")
                        .HasColumnType("float");

                    b.Property<string>("MaNhanVien")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<double>("PhiPhat")
                        .HasColumnType("float");

                    b.Property<double>("PhiThue")
                        .HasColumnType("float");

                    b.Property<DateTime>("ThoiGian")
                        .HasColumnType("datetime2");

                    b.HasKey("MaLuong");

                    b.HasIndex("MaNhanVien");

                    b.ToTable("Luong");
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.NgayCong", b =>
                {
                    b.Property<int>("MaCong")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MaNhanVien")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<int>("SoCThucTe")
                        .HasColumnType("int");

                    b.Property<int>("SoCVang")
                        .HasColumnType("int");

                    b.Property<int>("SoCgDiMuon")
                        .HasColumnType("int");

                    b.Property<int>("SoCong")
                        .HasColumnType("int");

                    b.Property<DateTime>("ThoiGianBD")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ThoiGianKT")
                        .HasColumnType("datetime2");

                    b.HasKey("MaCong");

                    b.HasIndex("MaNhanVien");

                    b.ToTable("NgayCong");
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.NhanVien", b =>
                {
                    b.Property<string>("MaNhanVien")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<byte>("Anh")
                        .HasColumnType("tinyint");

                    b.Property<string>("BienSoXe")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("ChucVu")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("GioiTinh")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("HangXe")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("HoTen")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("MaBP")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<int>("MaBaoHiem")
                        .HasColumnType("int");

                    b.Property<int>("MaLLV")
                        .HasColumnType("int");

                    b.Property<string>("MatKhau")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("MauXe")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<int>("PhanLoai")
                        .HasColumnType("int");

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("SoCCCD")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("TenTaiKhoan")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("MaNhanVien");

                    b.HasIndex("MaBP");

                    b.HasIndex("MaBaoHiem");

                    b.HasIndex("MaLLV");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.Phong", b =>
                {
                    b.Property<string>("MaP")
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("TenP")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.HasKey("MaP");

                    b.ToTable("Phong");
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.BaiViet", b =>
                {
                    b.HasOne("VNUA.FITA.MQTT.HRM.Data.Model.NhanVien", "NhanViens")
                        .WithMany("BaiViets")
                        .HasForeignKey("MaNhanVien");
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.BoPhan", b =>
                {
                    b.HasOne("VNUA.FITA.MQTT.HRM.Data.Model.Phong", "Phongs")
                        .WithMany("BoPhans")
                        .HasForeignKey("MaP");
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.DonTu", b =>
                {
                    b.HasOne("VNUA.FITA.MQTT.HRM.Data.Model.NhanVien", "NhanViens")
                        .WithMany("DonTus")
                        .HasForeignKey("MaNhanVien");
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.GiayTo", b =>
                {
                    b.HasOne("VNUA.FITA.MQTT.HRM.Data.Model.NhanVien", "NhanViens")
                        .WithMany("GiayTos")
                        .HasForeignKey("MaNhanVien");
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.HopDong", b =>
                {
                    b.HasOne("VNUA.FITA.MQTT.HRM.Data.Model.NhanVien", "NhanViens")
                        .WithMany("HopDongs")
                        .HasForeignKey("MaNhanVien");
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.Luong", b =>
                {
                    b.HasOne("VNUA.FITA.MQTT.HRM.Data.Model.NhanVien", "NhanViens")
                        .WithMany("Luongs")
                        .HasForeignKey("MaNhanVien");
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.NgayCong", b =>
                {
                    b.HasOne("VNUA.FITA.MQTT.HRM.Data.Model.NhanVien", "NhanViens")
                        .WithMany("NgayCongs")
                        .HasForeignKey("MaNhanVien");
                });

            modelBuilder.Entity("VNUA.FITA.MQTT.HRM.Data.Model.NhanVien", b =>
                {
                    b.HasOne("VNUA.FITA.MQTT.HRM.Data.Model.BoPhan", "BoPhans")
                        .WithMany("NhanViens")
                        .HasForeignKey("MaBP");

                    b.HasOne("VNUA.FITA.MQTT.HRM.Data.Model.BaoHiem", "BaoHiems")
                        .WithMany("NhanVien")
                        .HasForeignKey("MaBaoHiem")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("VNUA.FITA.MQTT.HRM.Data.Model.LichLamViec", "LichLamViecs")
                        .WithMany("NhanVien")
                        .HasForeignKey("MaLLV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
