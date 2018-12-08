using System;

namespace PressStart.API.DTOs
{
    public class PhotosForDetailsDTO
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAddeed { get; set; }
        public bool IsMain { get; set; }
    }
}