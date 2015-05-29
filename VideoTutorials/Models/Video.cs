using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoTutorials.Models
{
    public class Video
    {   
        [Key]
        public int VideoID { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Description")]
        public string Description { get; set; }
        [Required]
        public int DurationID { get; set; }
        public Duration Duration { get; set; }
        public int Views { get; set; }
        public int UserID { get; set; }
        [Required]
        public string Tags { get; set; }
        public virtual List<Category> Categories { get; set; }
    }
}