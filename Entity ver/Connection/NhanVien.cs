//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ADO_ver.Connection
{
    using System;
    using System.Collections.Generic;
    
    public partial class NhanVien
    {
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public string SDT { get; set; }
        public string Roles { get; set; }
    
        public virtual PhongBan PhongBan { get; set; }
    }
}
