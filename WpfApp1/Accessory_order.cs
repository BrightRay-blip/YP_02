//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Accessory_order
    {
        public int C___order { get; set; }
        public int Kode_A { get; set; }
        public string Order_status { get; set; }
    
        public virtual Accessories Accessories { get; set; }
        public virtual Order Order { get; set; }
    }
}
