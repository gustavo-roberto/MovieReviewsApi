using System.Threading.Tasks;
using MovieReviewsApi.Models;

namespace MovieReviewsApi.Communications
{
    public interface IHttpConsumerAuthenticationApi
    {
        public Task<IdReturnAuthenticationApi> UserLoginAsync(UserLoginApi user);
    }
}