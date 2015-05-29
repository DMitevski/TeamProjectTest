using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoTutorials.Models
{
    public class Duration
    {
        public int DurationID { get; set; }
        public string Length { get; set; }
        public virtual List<Video> Videos { get; set; }
    }
}