using System;

namespace DatingApp.API.Dtos
{
    public class PhotoForDetailDto
    {
        public long Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }
    }
}