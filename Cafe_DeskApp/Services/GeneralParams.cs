using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Cafe_DeskApp.Services
{
	public static class GeneralParams
	{	
		public static string Uri = "https://localhost:7213/api/Cafe/";

		public static HttpClient HttpCall()
		{
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(GeneralParams.Uri);
			return client;
        }
	}
}
