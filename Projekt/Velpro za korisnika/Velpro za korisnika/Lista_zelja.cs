//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Velpro_za_korisnika
{
    using System;
    using System.Collections.Generic;
    
    public partial class Lista_zelja
    {
        public int ID_lista_zelja { get; set; }
        public int ID_korisnika { get; set; }
        public string Naziv { get; set; }
        public string Opis { get; set; }
    
        public virtual Korisnici Korisnici { get; set; }
    }
}