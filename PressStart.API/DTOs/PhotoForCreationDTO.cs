using System;
using Microsoft.AspNetCore.Http;

namespace PressStart.API.DTOs
{
    public class PhotoForCreationDTO
    {
        public string Url { get; set; }
        public IFormFile File { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public string PublicId { get; set; }

        public PhotoForCreationDTO()
        {
            DateAdded = DateTime.Now;
        }
    }
}