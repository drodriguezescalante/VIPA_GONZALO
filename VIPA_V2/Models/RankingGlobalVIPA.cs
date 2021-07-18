using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VIPA_V2.Transfer;
namespace VIPA_V2.Models
{
    public partial class rankingglobal
    {
        public static IEnumerable<RankingGlobalDT> ListarRankingGlobal()
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var list = from b in db.rankingglobals.ToList()
                       select new RankingGlobalDT()
                       {
                           nivelraking = b.nivelraking,
                           nombrenivelranking = b.nombrenivelranking,
                           descripcionnivelranking = b.descripcionnivelranking,
                           puntosmaximos = b.puntosmaximos
                       };
            return list;
        }
        public static IEnumerable<RankingGlobalDT> ListarClasififacionNivel()
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var list = from b in db.rankingglobals.ToList()
                       select new RankingGlobalDT()
                       {
                           nivelraking = b.nivelraking,
                           nombrenivelranking = b.nombrenivelranking,
                           descripcionnivelranking = b.descripcionnivelranking,
                           puntosmaximos = b.puntosmaximos
                       };
            return list;
        }
    }
}