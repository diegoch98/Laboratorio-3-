using System;

namespace Laboratorio3.Models
{
    public class SongModel
    { 
        public int Id { get; set; }
        public string SongName { get; set; }
        public string Genre { get; set; }
        public DateTime ReleasedDate { get; set; }
        public string Singer { get; set; }
        public string Length { get; set; }
    }
}
