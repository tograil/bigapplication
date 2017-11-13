using System;
using System.Collections.Generic;
using System.Text;

namespace BaseApplicationEntities.Domain
{
    public class Message
    {
        public int Id { get; set; }
        public string UserLogin { get; set; }
        public string MessageBody { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
