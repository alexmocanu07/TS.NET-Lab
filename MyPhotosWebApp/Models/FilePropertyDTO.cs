using ServiceReferenceMyPhotos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhotosWebApp.Models
{
    public class FilePropertyDTO
    {
        public FilePropertyDTO(FileProperty fileProperty)
        {
            this.Id = fileProperty.Id;
            this.FileId = fileProperty.FileId;
            this.PropertyId = fileProperty.PropertyId;
            this.Value = fileProperty.Value;
        }
        
        public System.Guid Id { get; set; }
        
        public System.Guid FileId { get; set; }
        
        public System.Guid PropertyId { get; set; }
        
        public string Value { get; set; }
        
        public virtual FileDTO File { get; set; }
        
        public virtual PropertyDTO Property { get; set; }
    }
}
