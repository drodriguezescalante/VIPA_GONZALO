using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebVue.Models;

namespace WebVue.Logica
{
    public class LogicaReportador
    {
        public List<ReportadorDT2> ListarReportador()
        {      

            List<ReportadorDT2> data_devuelta = new List<ReportadorDT2>();
            var client = new RestClient();

            client.BaseUrl = new Uri("https://localhost/api");

            var request = new RestRequest("/Cliente/ListarReportador", Method.GET);

            IRestResponse<List<ReportadorDT2>> response = client.Execute<List<ReportadorDT2>>(request);


            data_devuelta = response.Data;

            return data_devuelta;
        }
            
    }
}