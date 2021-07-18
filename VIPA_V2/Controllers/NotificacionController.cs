using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VIPA_V2.Transfer;
using VIPA_V2.Models;
namespace VIPA_V2.Controllers
{
    public class NotificacionController : ApiController
    {
        [HttpGet]
        [Route("api/Notificacion/ListarNotificaciones")] //DR 10/07/2021:Ok
        public IEnumerable<NotificacionDT> ListarNotificaciones()
        {
            return notificacion.ListarNotificaciones();
        }

        [HttpGet]
        [Route("api/Notificacion/NotiActualizacion")] //DR 10/07/2021:Ok
        public IEnumerable<NotificacionDT> NotiActualizacion(DateTime fecha)
        {
            return notificacion.NotiActualizacion(fecha);
        }
        //api/Notificacion/NotiActualizacion?fecha=2021-06-27


        [HttpGet]
        [Route("api/Notificacion/NotiActuaEstado")] //DR 10/07/2021:Ok
        public IEnumerable<NotificacionDT> NotiActuaEstado()
        {
            return notificacion.NotiActuaEstado();
        }
    }
}
