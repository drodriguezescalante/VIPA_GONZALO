﻿using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebVue.Logica
{
    public static class RestHelper<TRequest, TResponse>
         where TRequest : class
         where TResponse : class, new()
    {
        public static TResponse ExecutePost(string metodo, TRequest request)
        {
            var client = new RestClient("http://localhost/api");

            var restRequest = new RestRequest(metodo, Method.POST)
            {
                RequestFormat = DataFormat.Json,

            };

            restRequest.AddJsonBody(request);


            var restResponse = client.Execute<TResponse>(restRequest);

            TResponse data = restResponse.Data;

            return data;
        }

        public static TResponse ExecuteGet(string metodo, TRequest request)
        {
            var client = new RestClient("http://localhost/api");

            var restRequest = new RestRequest(metodo, Method.GET)
            {
                RequestFormat = DataFormat.Json,

            };

            restRequest.AddJsonBody(request);


            var restResponse = client.Execute<TResponse>(restRequest);

            TResponse data = restResponse.Data;

            return data;
        }
    }
}