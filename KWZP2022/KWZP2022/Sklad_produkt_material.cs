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
    
    public partial class Sklad_produkt_material
    {
        public int ID_sklad_produkt_material { get; set; }
        public int ID_produkt { get; set; }
        public int ID_material { get; set; }
        public int Liczba { get; set; }
    
        public virtual Material Material { get; set; }
        public virtual Produkt Produkt { get; set; }
    }
}