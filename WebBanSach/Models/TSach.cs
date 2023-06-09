﻿using System;
using System.Collections.Generic;

namespace WebBanSach.Models;

public partial class TSach
{
    public int MaSach { get; set; }

    public string TenSach { get; set; } = null!;

    public string TacGia { get; set; } = null!;

    public double? DonGia { get; set; }

    public int? SoLuong { get; set; }

    public int? MaTl { get; set; }

    public int? MaNxb { get; set; }

    public string? Anh { get; set; }

    public int? MaNg { get; set; }

    public string? Mota { get; set; }

    public virtual TNgonNgu? MaNgNavigation { get; set; }

    public virtual TNhaXuatBan? MaNxbNavigation { get; set; }

    public virtual TTheLoai? MaTlNavigation { get; set; }

    public virtual ICollection<TChiTietHoaDon> TChiTietHoaDons { get; } = new List<TChiTietHoaDon>();

    public virtual ICollection<TSachKho> TSachKhos { get; } = new List<TSachKho>();
}
