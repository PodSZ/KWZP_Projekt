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
    
    public partial class Sklad_produkt
    {
        public int ID_sklad_produkt { get; set; }
        public int ID_produkt { get; set; }
        public int ID_polprodukt { get; set; }
        public int Liczba { get; set; }
    
        public virtual Produkt Produkt { get; set; }
        public virtual Slownik_polprodukt Slownik_polprodukt { get; set; }
    }
}
