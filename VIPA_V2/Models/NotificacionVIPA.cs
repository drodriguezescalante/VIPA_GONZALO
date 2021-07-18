using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VIPA_V2.Transfer;
namespace VIPA_V2.Models
{
    public partial class notificacion
    {
        public static IEnumerable<NotificacionDT> NotiActualizacion(DateTime fecha)
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            DateTime fechai = new DateTime(2018, 11, 13);
            var obj = from b in db.notificacions.Where(x => x.nombrenotificacion == "Actualizacion de aplicacion"
                      && x.fechadespliegue <= fecha && x.fechadespliegue >= fechai).Take(1)
                      select new NotificacionDT()
                      {
                          idnotificacion = b.idnotificacion,
                          nombrenotificacion = b.nombrenotificacion,
                          descripcionnotificacion = b.descripcionnotificacion,
                          urlincidente = b.urlincidente,
                          fechadespliegue = b.fechadespliegue
                      };
            return obj;
        }
        public static IEnumerable<NotificacionDT> ListarNotificaciones()
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var list = from b in db.notificacions.Where(x => x.nombrenotificacion != "Actualizacion de aplicacion" &&
                       x.nombrenotificacion != "Estado de Reporte")
                       select new NotificacionDT()
                       {
                           idnotificacion = b.idnotificacion,
                           nombrenotificacion = b.nombrenotificacion,
                           descripcionnotificacion = b.descripcionnotificacion,
                           urlincidente = b.urlincidente,
                           fechadespliegue = b.fechadespliegue
                       };
            return list;
        }
        public static IEnumerable<NotificacionDT> NotiActuaEstado()
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var obj = from b in db.notificacions.Where(x => x.nombrenotificacion == "Estado de Reporte")
                      select new NotificacionDT()
                      {
                          idnotificacion = b.idnotificacion,
                          nombrenotificacion = b.nombrenotificacion,
                          descripcionnotificacion = b.descripcionnotificacion,
                          urlincidente = b.urlincidente,
                          fechadespliegue = b.fechadespliegue
                      };
            return obj;
        }
    }
}