//------------------------------------------------------------------------------
// <auto-generated>
//     Codice generato da un modello.
//
//     Le modifiche manuali a questo file potrebbero causare un comportamento imprevisto dell'applicazione.
//     Se il codice viene rigenerato, le modifiche manuali al file verranno sovrascritte.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class GlobalBan
    {
        public int Id { get; set; }
        public int TelegramId { get; set; }
        public string Reason { get; set; }
        public System.DateTime Expires { get; set; }
        public string BannedBy { get; set; }
        public Nullable<System.DateTime> BanDate { get; set; }
        public string Name { get; set; }
    }
}
