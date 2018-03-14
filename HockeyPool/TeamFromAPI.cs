
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HockeyPool
{
    class TeamFromAPI
    {
            

        static HttpClient client = new HttpClient();

        static void ShowTeam(Team t)
        {
            MessageBox.Show($"Name: {t.name}");
        }



        static async Task<Uri> CreateProductAsync(Team t)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "teams", t);
            response.EnsureSuccessStatusCode();

            // return URI of the created resource.
            return response.Headers.Location;
        }

        static async Task<Team> GetProductAsync(string path)
        {
            Team t = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                t = await response.Content.ReadAsAsync<Team>();
            }
            return t;
        }

        static async Task<Team> UpdateProductAsync(Team t)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"/teams/{t.id}", t);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            t = await response.Content.ReadAsAsync<Team>();
            return t;
        }

        static async Task<HttpStatusCode> DeleteProductAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"teams/{id}");
            return response.StatusCode;
        }

        static void Maint()
        {
            RunAsync().GetAwaiter().GetResult();
        }

        public static async Task RunAsync()
        {
            // Update port # in the following line.
            client.BaseAddress = new Uri("http://statsapi.web.nhl.com/api/v1/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                // Create a new product
                Team t = new Team
                {
                    name = "Capitals",
                    id = 15
                };
                
                var url = await GetProductAsync("http://statsapi.web.nhl.com/api/v1/teams/15");
                ShowTeam(t);

                //var url = await CreateProductAsync(t);
                //Console.WriteLine($"Created at {url}");

                //// Get the product
                //t = await GetProductAsync(url.PathAndQuery);
                //ShowTeam(t);

                //// Update the product
                //Console.WriteLine("Updating price...");
                ////t.Price = 80;
                ////await UpdateProductAsync(t);

                //// Get the updated product
                //t = await GetProductAsync(url.PathAndQuery);
                //ShowTeam(t);

                //// Delete the product
                //var statusCode = await DeleteProductAsync(t.id);
                //Console.WriteLine($"Deleted (HTTP Status = {(int)statusCode})");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}

