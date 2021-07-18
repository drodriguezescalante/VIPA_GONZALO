using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VIPA_V2.Transfer;
namespace VIPA_V2.Models
{
    public partial class estadoperfilranking
    {
        public static IEnumerable<EstadoPerfilRankingDT> ListarPerfilRanking()
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var list = from b in db.estadoperfilrankings.ToList()
                       select new EstadoPerfilRankingDT()
                       {
                           idestadoperfil = b.idestadoperfil,
                           nivelraking = b.nivelraking,
                           puntosactuales = b.puntosactuales,
                           posicionglobalranking = b.posicionglobalranking
                       };
            return list;
        }
        public static IEnumerable<EstadoPerfilRankingDT> ListarRankingPuntos()
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var list = from b in db.estadoperfilrankings.OrderByDescending(x => x.puntosactuales)
                       select new EstadoPerfilRankingDT()
                       {
                           idestadoperfil = b.idestadoperfil,
                           nivelraking = b.nivelraking,
                           puntosactuales = b.puntosactuales
                       };
            return list;
        }
        public static IEnumerable<EstadoPerfilRankingDT2> ListarNivelDesbloqueado()
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var list = from b in db.estadoperfilrankings.OrderByDescending(x => x.puntosactuales)
                       select new EstadoPerfilRankingDT2()
                       {
                           idestadoperfil = b.idestadoperfil,
                           nivelraking = b.nivelraking,
                           puntosactuales = b.puntosactuales,
                           ranking = new RankingGlobalDT
                           {
                               nombrenivelranking = b.rankingglobal.nombrenivelranking,
                               descripcionnivelranking = b.rankingglobal.descripcionnivelranking,
                           }
                       };
            return list;
        }
        public static EstadoPerfilRankingDT4 ObtenerPerfilRanking(string id)
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var obj = db.estadoperfilrankings.Select(b => new EstadoPerfilRankingDT4()
            {
                idestadoperfil = b.idestadoperfil,
                nivelraking = b.nivelraking,
                puntosactuales = b.puntosactuales
            }).SingleOrDefault(b => b.idestadoperfil == id);

            if (obj == null) obj = new EstadoPerfilRankingDT4() { idestadoperfil = "" };

            return obj;
        }
    }
}