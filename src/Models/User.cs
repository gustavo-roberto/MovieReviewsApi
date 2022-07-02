using System;

namespace MovieReviewsApi.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public int Pontos { get; set; }
        public string Email { get; set; }      
    }
}