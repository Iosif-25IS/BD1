//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp2
{
    using System;
    using System.Collections.Generic;
    
    public partial class HotelOfTour
    {
        public int Hotelid { get; set; }
        public int Tourid { get; set; }
    
        public virtual Hotel Hotel { get; set; }
        public virtual Tour Tour { get; set; }
    }
}