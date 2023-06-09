﻿using System;
using System.Collections.Generic;

namespace WebBanSach.Models;

public partial class TUser
{
    public int Id { get; set; }

    public string UserN { get; set; } = null!;

    public string? DiaChi { get; set; }

    public int? Sdt { get; set; }

    public string? Email { get; set; }

    public string? PassW { get; set; }

    public string? RoleId { get; set; }

    public virtual TUserRole? Role { get; set; }

    public virtual ICollection<THoaDon> THoaDons { get; } = new List<THoaDon>();
}
