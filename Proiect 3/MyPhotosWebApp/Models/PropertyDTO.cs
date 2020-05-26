using ServiceReferenceMyPhotos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPhotosWebApp.Models
{
    public class PropertyDTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PropertyDTO()
        {
            this.FileProperties = new HashSet<FilePropertyDTO>();
        }

        public PropertyDTO(Property property)
        {
            this.FileProperties = new HashSet<FilePropertyDTO>();
            this.Id = property.Id;
            this.Name = property.Name;
            this.Description = property.Description;
            this.DataType = property.DataType;
            this.Editable = property.Editable;
        }
        
        public System.Guid Id { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public string DataType { get; set; }
        
        public bool Editable { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        
        public virtual ICollection<FilePropertyDTO> FileProperties { get; set; }
    }
}
