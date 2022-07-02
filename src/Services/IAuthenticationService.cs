using MovieReviewsApi.Models;

namespace MovieReviewsApi.Services
{
    public interface IAuthenticationService
    {
        public void LoginUser(UserLoginApi user);
        public void UserCreation(UserCreationApi user);
    }
}