using System;
using System.Text.Json.Serialization;

namespace MovieReviewsApi.Models
{
    public class IdReturnAuthenticationApi
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }    
        
    }
}