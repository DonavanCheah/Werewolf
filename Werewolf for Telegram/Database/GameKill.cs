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
    
    public partial class GameKill
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public int KillerId { get; set; }
        public int VictimId { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public int KillMethodId { get; set; }
        public int Day { get; set; }
    
        public virtual Game Game { get; set; }
        public virtual Player Player { get; set; }
        public virtual KillMethod KillMethod { get; set; }
        public virtual Player Player1 { get; set; }
    }
}
