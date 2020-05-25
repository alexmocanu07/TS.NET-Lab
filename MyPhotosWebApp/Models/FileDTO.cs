using ServiceReferenceMyPhotos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhotosWebApp.Models
{
    public class FileDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FileDTO()
        {
            this.FileProperties = new HashSet<FilePropertyDTO>();
        }
        public FileDTO(File file)
        {
            this.FileProperties = new HashSet<FilePropertyDTO>();
            this.Id = file.Id;
            this.Name = file.Name;
            this.Path = file.Path;
            this.Deleted = file.Deleted;
        }

        public System.Guid Id { get; set; }

        public string Name { get; set; }

        public string Path { get; set; }

        public bool Deleted { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilePropertyDTO> FileProperties { get; set; }
    }
}
