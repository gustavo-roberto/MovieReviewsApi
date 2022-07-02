using MovieReviewsApi.Communications;
using MovieReviewsApi.Models;

namespace MovieReviewsApi.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IHttpConsumerAuthenticationApi _httpAuthenticationApi;
        public AuthenticationService(IHttpConsumerAuthenticationApi httpAuthenticationApi)
        {
            _httpAuthenticationApi = httpAuthenticationApi;
            
        }
        public async void LoginUser(UserLoginApi user)
        {
            await _httpAuthenticationApi.UserLoginAsync(user);
        }
    }
}