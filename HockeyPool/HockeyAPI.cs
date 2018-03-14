﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

namespace HockeyPool
{
    class HockeyAPI
    {
        HttpClient client;

        public HockeyAPI()
        {
            client = new HttpClient();

            client.BaseAddress = new Uri("https://statsapi.web.nhl.com/api/v1/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<Product> GetTeams()
        {
            Product product = null;

            try
            {

                HttpResponseMessage response = await client.GetAsync("teams");
                if (response.IsSuccessStatusCode)
                {
                    product = await response.Content.ReadAsAsync<Product>();
                }

                else
                {
                    return null;
                }
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return product;
        }

    }
}
