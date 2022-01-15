using System;
using System.Collections.Generic;

#nullable disable

namespace Meta.Models
{
    public partial class CommentToComment
    {
        public int Id { get; set; }
        public int CommentId { get; set; }
        public int ReplyCommentId { get; set; }

        public virtual Comment Comment { get; set; }
        public virtual Comment ReplyCommentNavigation { get; set; }
    }
}
