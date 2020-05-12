using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPostComment.Models
{
    public class PostDTO
    {
        public int PostId { get; set; }
        public string Description { get; set; }
        public string Domain { get; set; }
        public System.DateTime Date { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual List<CommentDTO> Comments { get; set; }
    }
}
