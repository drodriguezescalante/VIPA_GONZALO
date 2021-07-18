using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VIPA_V2.Transfer
{
    public class ValoracionReporteDT
    {
        public string idvaloracion { get; set; }
        public string segundotipovaloracion { get; set; }
        public string idreporte { get; set; }
        public string idreportador { get; set; }
        public int idtiporeporte { get; set; }
    }
    public class ValoracionReporteUrlDT
    {
        public string idvaloracion { get; set; }
        public string segundotipovaloracion { get; set; }
        public string reportevideo { get; set; }
        public string idreporte { get; set; }
        public string idreportador { get; set; }
        public int idtiporeporte { get; set; }
        public EstadoPerfilRankingPuntosDT puntosganados { get; set; }
    }
    public class EstadoPerfilRankingDT4
    {
        public string idestadoperfil { get; set; }
        public int nivelraking { get; set; }
        public Nullable<int> puntosactuales { get; set; }
    }
    public class EstadoPerfilRankingDT5
    {
        public int idestadoperfil { get; set; }
        public int nivelraking { get; set; }
        public Nullable<int> puntosactuales { get; set; }
        public RankingGlobalDT2 ranking { get; set; }
    }


    public class EstadoPerfilRankingPuntosDT
    {
        public Nullable<int> puntos { get; set; }
    }
}