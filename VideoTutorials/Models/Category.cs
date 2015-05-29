using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VideoTutorials.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
        public virtual List<Video> Videos { get; set; }
    }
}
