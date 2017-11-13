using System;
using System.Collections.Generic;
using System.Text;

namespace BaseApplicationEntities.Domain
{
    public class Note
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Colour { get; set; }
        public int Left { get; set; }
        public int Top { get; set; }
    }
}
