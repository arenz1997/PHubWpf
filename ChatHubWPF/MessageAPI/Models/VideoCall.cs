using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MessageAPI.Models
{
    public class VideoCall
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string From { get; set; }
        [Required]
        public string To { get; set; }
        public byte[] Buffer { get; set; }
        [Required]
        public bool IsAccepted { get; set; }
    }
}
