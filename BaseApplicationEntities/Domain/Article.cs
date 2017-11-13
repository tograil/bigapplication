using System;
using System.Collections.Generic;
using System.Text;

namespace BaseApplicationEntities.Domain
{
    public class Article
    {
        public int Id { get; set; }
        public string Slug { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
