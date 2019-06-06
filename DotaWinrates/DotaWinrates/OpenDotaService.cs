using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Formatting;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Json;
using RestSharp;
using System.Collections.Generic;

namespace DotaWinrates
{
    public class OpenDotaService
    {
		HttpClient _client;

		public OpenDotaService()
		{
			_client = new HttpClient();
		}

		public IRestResponse GetOpenDotaDataAsync(string sql)
		{ 
			var client = new RestClient("https://api.opendota.com/api");
			var request = new RestRequest("/explorer", Method.GET);
			request.AddParameter("sql",sql,ParameterType.QueryString);
			IRestResponse queryResult = client.Execute(request);
			var fullUrl = client.BuildUri(request);
			return queryResult;
			
		}
	}
}
