﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;


namespace PostComment
{
    public partial class Post
    {
        public bool AddPost()
        {
            using (ModelPostCommentContainer ctx = new ModelPostCommentContainer())
            {
                bool bResult = false;
                if (this.PostId == 0)
                {
                    var it = ctx.Entry<Post>(this).State = EntityState.Added;
                    ctx.SaveChanges();
                    bResult = true;
                }
                return bResult;
            }
        }

        public Post UpdatePost(Post newPost)
        {
            using (ModelPostCommentContainer ctx = new ModelPostCommentContainer())
            {
                Post oldPost = ctx.Posts.Find(newPost.PostId);
                if (oldPost == null) 
                {
                    return null;
                }
                oldPost.Description = newPost.Description;
                oldPost.Domain = newPost.Domain;
                oldPost.Date = newPost.Date;
                ctx.SaveChanges();
                return oldPost;
            }
        }

        public int DeletePost(int id)
        {
            using (ModelPostCommentContainer ctx = new ModelPostCommentContainer())
            {
                return ctx.Database.ExecuteSqlCommand("Delete From Post where postid = @p0", id);
            }
        }
        public Post GetPostById(int id)
        {
            using (ModelPostCommentContainer ctx = new ModelPostCommentContainer())
            {
                var items = from p in ctx.Posts where (p.PostId == id) select p;
                if (items != null)
                    return items.Include(c => c.Comments).SingleOrDefault();
                return null; 
            }
        }

        public List<Post> GetAllPosts()
        {
            using (ModelPostCommentContainer ctx = new ModelPostCommentContainer())
            {
                return ctx.Posts.Include("Comments").ToList<Post>();
            }
        }
    }
}
