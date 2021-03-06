﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

using AKS_API.Model;

namespace WebApplication1.Pages
{
    public class IndexModel : PageModel
    {

        public List<Hero> Heroes { get; set; }

        public void OnGet()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://172.20.0.3:82/");
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage message = client.GetAsync("api/heroes").Result;
            if (message.IsSuccessStatusCode)
            {
                string result = message.Content.ReadAsStringAsync().Result;
                Heroes = JsonConvert.DeserializeObject<List<Hero>>(result);
            }
        }
    }
}
