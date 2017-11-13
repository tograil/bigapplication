using System;
using System.Collections.Generic;
using System.Text;

namespace BaseApplicationEntities.Domain
{
    public class Claim
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SortOrder { get; set; }
        public string ImageLabel { get; set; }
        public string ImageLink { get; set; }
    }
}
