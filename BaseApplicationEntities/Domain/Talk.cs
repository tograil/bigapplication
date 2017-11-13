using System;
using System.Collections.Generic;
using System.Text;

namespace BaseApplicationEntities.Domain
{
    public class Talk
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Speaker { get; set; }
        public string Description { get; set; }
        public string YourRating { get; set; }
        public float Rating { get; set; }
    }
}
