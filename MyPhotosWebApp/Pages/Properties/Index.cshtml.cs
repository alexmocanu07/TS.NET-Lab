using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferenceMyPhotos;
using MyPhotosWebApp.Models;

namespace MyPhotosWebApp.Pages.Properties
{
    public class IndexModel : PageModel
    {
        public List<FileDTO> Files { get; set; }
        public List<FilePropertyDTO> FileProperties { get; set; }
        public List<PropertyDTO> Properties { get; set; }
        public Dictionary<PropertyDTO, string> propertyValueDictionary;
        public DatabaseClient client = new DatabaseClient();
        public string imageName;
        public IndexModel()
        {
            Files = new List<FileDTO>();
            FileProperties = new List<FilePropertyDTO>();
            Properties = new List<PropertyDTO>();
            propertyValueDictionary = new Dictionary<PropertyDTO, string>();
        }

        public async Task OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return;
            }
            Guid guid = id.GetValueOrDefault();

            var file = await client.GetFileAsync(guid);
            FileDTO fileDTO = new FileDTO(file);
            imageName = fileDTO.Name;
            var properties = await client.GetFilePropertiesAsync(guid);
            foreach(var prop in properties)
            {
                PropertyDTO property = new PropertyDTO(prop);
                Properties.Add(property);
                var fileProperty = await client.GetFilePropertyAsync(guid, property.Id);
                propertyValueDictionary.Add(property, fileProperty.Value);
            }
            
        }
    }
}