using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VIPA_V2.Transfer;
namespace VIPA_V2.Transfer
{
    public class EstadoPerfilRankingDT
    {
        public string idestadoperfil { get; set; }
        public int nivelraking { get; set; }
        public Nullable<int> puntosactuales { get; set; }
        public Nullable<int> posicionglobalranking { get; set; }
    }
    public class EstadoPerfilRankingDT2
    {
        public string idestadoperfil { get; set; }
        public int nivelraking { get; set; }
        public Nullable<int> puntosactuales { get; set; }
        public RankingGlobalDT ranking { get; set; }
    }
    public class EstadoPerfilRankingDT3
    {
        public Nullable<int> puntos { get; set; }
    }
}