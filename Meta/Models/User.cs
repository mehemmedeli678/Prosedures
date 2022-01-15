using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class User
    {
        public User()
        {
            Buyings = new HashSet<Buying>();
            Comments = new HashSet<Comment>();
            FavoryContents = new HashSet<FavoryContent>();
            FavorySeries = new HashSet<FavorySeries>();
            Histories = new HashSet<History>();
            LikedContents = new HashSet<LikedContent>();
            LikedSeries = new HashSet<LikedSeries>();
            Subscribers = new HashSet<Subscriber>();
            UserToRoles = new HashSet<UserToRole>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RegisterDate { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedOn { get; set; }
        public virtual ICollection<Buying> Buyings { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<FavoryContent> FavoryContents { get; set; }
        public virtual ICollection<FavorySeries> FavorySeries { get; set; }
        public virtual ICollection<History> Histories { get; set; }
        public virtual ICollection<LikedContent> LikedContents { get; set; }
        public virtual ICollection<LikedSeries> LikedSeries { get; set; }
        public virtual ICollection<Subscriber> Subscribers { get; set; }
        public virtual ICollection<UserToRole> UserToRoles { get; set; }
    }
}
