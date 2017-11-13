using System;
using System.Collections.Generic;
using System.Text;

namespace BaseApplicationEntities.Domain
{
    public class Rebuttal
    {
        public int Id { get; set; }
        public string LongName { get; set; }
        public string ShortName { get; set; }
        public DateTime Date { get; set; }
        public DateTime Expires { get; set; }
        public string Link { get; set; }
    }
}
