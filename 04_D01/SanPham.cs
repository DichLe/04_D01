//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _04_D01
{
    using System;
    using System.Collections.Generic;
    
    public partial class SanPham
    {
        public Nullable<int> MaLoai { get; set; }
        public int MaSP { get; set; }
        public string Ten { get; set; }
        public Nullable<int> Gia { get; set; }
        public string Anh { get; set; }
        public string MoTa { get; set; }
        public Nullable<int> KhuyenMai { get; set; }
    
        public virtual LoaiSP LoaiSP { get; set; }
    }
}
