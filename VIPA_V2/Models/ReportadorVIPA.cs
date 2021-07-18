using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VIPA_V2.Transfer;
namespace VIPA_V2.Models
{
    public partial class reportador
    {



        public static ReportadorDT LoginReportador(string correoreportador, string contraseniareportador)
        {
            vipa_databaseEntities db = new vipa_databaseEntities();

            var e = (from p in db.reportadors
                     where p.correoreportador == correoreportador && p.contraseniareportador == contraseniareportador
                     select p).Any();
            if (e)
            {
                ReportadorDT obj = new ReportadorDT();
                obj = ObtenerReportador2(correoreportador);
                return obj;
            }
            else
            {
                ReportadorDT obj = new ReportadorDT();
                obj.response = false;
                return obj;
            }
        }

        public static bool verificacodigo(string id, string codigo)
        {
            vipa_databaseEntities db = new vipa_databaseEntities();

            var e = (from p in db.reportadors
                     where p.idreportador == id && p.verificacionperfil == codigo
                     select p).Any();
            if (e)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static ReportadorDT ObtenerReportador2(string correo)
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var obj = db.reportadors.Select(b =>
            new ReportadorDT()
            {
                idreportador = b.idreportador,
                aliasusuario = b.aliasusuario,
                perfilvisible = b.perfilvisible,
                nombrereportador = b.nombrereportador,
                apellidosreportador = b.apellidosreportador,
                correoreportador = b.correoreportador,
                verificacionperfil = b.verificacionperfil,
                estadoverficacion = b.estadoverificacion,
                response = true
            }).SingleOrDefault(b => b.correoreportador == correo);
            return obj;
        }

        public static IEnumerable<ReportadorDT2> ListarReportador()
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var list = from b in db.reportadors.ToList()
                       select new ReportadorDT2()
                       {
                           idreportador = b.idreportador,
                           aliasusuario = b.aliasusuario,
                           perfilvisible = b.perfilvisible,
                           nombrereportador = b.nombrereportador,
                           apellidosreportador = b.apellidosreportador,
                           correoreportador = b.correoreportador,
                           contraseniareportador = b.contraseniareportador,
                           idestadoperfil = b.idestadoperfil,
                           verificacionperfil = b.verificacionperfil
                       };
            return list;
        }


        public static ReportadorDT IngresarReportador(ReportadorDT rep)
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            Random random = new Random();
            String codigo = random.Next(100000,999999).ToString();
            String contador = db.reportadors.Count().ToString();

            reportador obj = new reportador()
            {
                idreportador = "RE"+contador,
                aliasusuario = rep.aliasusuario,
                perfilvisible = "0",
                nombrereportador = rep.nombrereportador,
                apellidosreportador = rep.apellidosreportador,
                correoreportador = rep.correoreportador,
                contraseniareportador = rep.contraseniareportador,
                idestadoperfil = "-",
                verificacionperfil = codigo,
                estadoverificacion = 0
            };
            db.reportadors.Add(obj);
            db.SaveChanges();
            return ObtenerReportador(obj.idreportador);
        }

        public static bool CuentaVerificada(cuentaverificada cue)
        {
            try
            {
                using (var context = new vipa_databaseEntities())
                {
                    context.cuentaverificadas.Add(cue);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        public static ReportadorDT ObtenerReportador(string id)
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            var obj = db.reportadors.Select(b =>
            new ReportadorDT()
            {
                idreportador = b.idreportador,
                aliasusuario = b.aliasusuario,
                perfilvisible = b.perfilvisible,
                nombrereportador = b.nombrereportador,
                apellidosreportador = b.apellidosreportador,
                correoreportador = b.correoreportador,
                verificacionperfil = b.verificacionperfil,
                estadoverficacion = b.estadoverificacion
            }).SingleOrDefault(b => b.idreportador == id);
            return obj;
        }

        public static ReportadorDT ActualizarPerfil(string id, ReportadorDT r)
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            reportador obj = db.reportadors.SingleOrDefault(m => m.idreportador == id);

            obj.aliasusuario = r.aliasusuario;
            obj.perfilvisible = r.perfilvisible;
            obj.nombrereportador = r.nombrereportador;
            obj.apellidosreportador = r.apellidosreportador;
            obj.correoreportador = r.correoreportador;

            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
            return ObtenerReportador(id);
        }

        public static bool verificarperfil(string id)
        {
            vipa_databaseEntities db = new vipa_databaseEntities();
            reportador obj = db.reportadors.SingleOrDefault(m => m.idreportador == id);

            obj.estadoverificacion = 1;

            db.Entry(obj).State = EntityState.Modified;
            db.SaveChanges();
            return true;
        }
    }
}