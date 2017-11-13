using System;
using System.Collections.Generic;
using System.Text;

namespace BaseApplicationEntities.Domain
{
    public class SocialUserConnection
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string ProviderId { get; set; }
        public string ProviderUserId { get; set; }
        public int Rank { get; set; }
        public string DisplayName { get; set; }
        public string ProfileUrl { get; set; }
        public string ImageUrl { get; set; }
        public string AccessToken { get; set; }
        public string Secret { get; set; }
        public string RefreshToken { get; set; }
        public string ExpireTime { get; set; }
    }
}
