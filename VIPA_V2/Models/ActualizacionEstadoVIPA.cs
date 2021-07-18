using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VIPA_V2.Models;
using VIPA_V2.Transfer;
namespace VIPA_V2.Models
{
    public partial class reporte
    {
        public static ActualizacionEstadoDT obteneractualizaciones(string id)
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            ActualizacionEstadoDT obj = db.reportes.Select(b => new ActualizacionEstadoDT()
            {
                idreporte = b.idreporte,
                idurlvideo = b.idurlgps,
                estadoreporte = b.estadoreporte
            }).SingleOrDefault(b => b.idreporte == id);
            if (obj == null) obj = new ActualizacionEstadoDT() { idreporte = "No existe" };
            return obj;
        }
    }
}