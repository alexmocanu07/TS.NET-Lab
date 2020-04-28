using Grpc.Core;
using GrpcService.Protos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PostComment.APIStatic;
using PostComment;

namespace GrpcService.Services
{
    public class PostCommentService : Protos.GrpcApi.GrpcApiBase
    {
        private Comment GetCommentFromModel(CommentModel model)
        {
            return new Comment()
            {
                CommentId = model.CommentId,
                Text = model.Text,
                PostPostId = model.PostPostId
            };
        }
        private Post GetPostFromPostModel(PostModel model)
        {
            var comments = model.Comments;

            var p = new Post()
            {
                PostId = model.PostId,
                Domain = model.Domain,
                Description = model.Descripion,
                Date = DateTime.Parse(model.Date.ToString())
            };

            p.Comments.AddRange(model.Comments.Select(GetCommentFromModel));

            return p;
            
        }
        public override Task<BoolResultMessage> AddPost(PostModel newPost, ServerCallContext context)
        {
            bool result = API.AddPost(GetPostFromPostModel(newPost));

            return Task.FromResult(new BoolResultMessage()
            {
                Result = result
            });
        }
    }
}
