//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KWZP2022
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sklad_maszyna
    {
        public int ID_sklad_maszyna { get; set; }
        public int ID_maszyna { get; set; }
        public int ID_czesc { get; set; }
        public int Liczba_czesci { get; set; }
    
        public virtual Czesc Czesc { get; set; }
        public virtual Maszyna Maszyna { get; set; }
    }
}
