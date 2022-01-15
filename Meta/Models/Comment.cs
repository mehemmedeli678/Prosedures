using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class Comment
    {
        public Comment()
        {
            CinemaLabToComments = new HashSet<CinemaLabToComment>();
            CommentToCommentComments = new HashSet<CommentToComment>();
            CommentToCommentReplyCommentNavigations = new HashSet<CommentToComment>();
            FilmToComments = new HashSet<FilmToComment>();
            SeriesToComments = new HashSet<SeriesToComment>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public string Text { get; set; }
        public bool Spolier { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime ModifiedOn { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<CinemaLabToComment> CinemaLabToComments { get; set; }
        public virtual ICollection<CommentToComment> CommentToCommentComments { get; set; }
        public virtual ICollection<CommentToComment> CommentToCommentReplyCommentNavigations { get; set; }
        public virtual ICollection<FilmToComment> FilmToComments { get; set; }
        public virtual ICollection<SeriesToComment> SeriesToComments { get; set; }
    }
}
