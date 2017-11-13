using System;
using System.Collections.Generic;
using System.Text;

namespace BaseApplicationEntities.Domain
{
    public class ClaimRebuttal
    {
        public int Id { get; set; }
        public int ClaimId { get; set; }
        public int RebuttalId { get; set; }
        public int SortOrder { get; set; }
    }
}
