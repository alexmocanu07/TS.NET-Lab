using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferencePostComment;
using RazorPostComment.Models;

namespace RazorPostComment.Pages.Posts
{
    public class EditModel : PageModel
    {
        PostCommentClient pcc = new PostCommentClient();

        [BindProperty]
        public PostDTO PostDTO { get; set; }
        
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            int id1 = id.GetValueOrDefault(-1);
            if(id1 == -1)
            {
                return NotFound();
            }

            Post post = await pcc.GetPostByIdAsync(id1);

            if (post == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Post post = new Post();
            post.Date = PostDTO.Date;
            post.Description = PostDTO.Description;
            post.Domain = PostDTO.Domain;
            post.PostId = PostDTO.PostId;
            var result = await pcc.UpdatePostAsync(post);
            if (result == null)
            {
                return RedirectToPage("Error");
            }

            return RedirectToPage("./Index");
        }

    }
}