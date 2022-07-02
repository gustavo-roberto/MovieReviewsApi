using System;

namespace MovieReviewsApi.Models
{
    public class UserLoginApi : UserCreationApi
    {
        public string Role { get; set; }
    }
}