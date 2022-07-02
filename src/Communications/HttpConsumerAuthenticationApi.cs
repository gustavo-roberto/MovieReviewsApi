using System.Threading.Tasks;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http.Headers;
using MovieReviewsApi.Models;
using System.Net.Http.Json;
using System.Security.Authentication;
using System.Net;
using Newtonsoft.Json;

namespace MovieReviewsApi.Communications
{
    public class HttpConsumerAuthenticationApi : IHttpConsumerAuthenticationApi
    {
        private readonly IConfiguration _configuration;
        HttpClient client;
        public HttpConsumerAuthenticationApi(IConfiguration configuration)
        {
            _configuration = configuration;
            client = new HttpClient();
            client.BaseAddress = new Uri(_configuration["Authentication:BaseAddress"]);
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<IdReturnAuthenticationApi> UserLoginAsync(UserLoginApi user)
        {
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue($"Bearer",$"{bearerToken}");
            HttpResponseMessage response = await client.PostAsJsonAsync("api/UserLogin", user);
            if (response.IsSuccessStatusCode)
            {
                var data = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IdReturnAuthenticationApi>(data);
                
            }
            else if (response.StatusCode.Equals(HttpStatusCode.BadRequest))
            {
                throw new AuthenticationException("Failed to Authenticate. Incorrect Email or Password.");
            }
            else
            {
                throw new Exception(response.StatusCode.ToString());
            }
        }
    }
}