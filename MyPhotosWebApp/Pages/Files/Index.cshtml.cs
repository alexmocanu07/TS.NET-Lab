using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferenceMyPhotos;
using MyPhotosWebApp.Models;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;

namespace MyPhotosWebApp.Pages.Files
{
    public class IndexModel : PageModel
    {
        public List<FileDTO> Files { get; set; }
        public List<FilePropertyDTO> FileProperties { get; set; }
        public List<PropertyDTO> Properties { get; set; }
        public Dictionary<FileDTO, List<PropertyDTO>> filePropertyDictionary;
        public DatabaseClient client = new DatabaseClient();
        public IndexModel()
        {
            Files = new List<FileDTO>();
            FileProperties = new List<FilePropertyDTO>();
            Properties = new List<PropertyDTO>();
            filePropertyDictionary = new Dictionary<FileDTO, List<PropertyDTO>>();
        }
        public async Task OnGetAsync()
        {
            var files = await client.GetAllFilesAsync();
            foreach(var file in files)
            {
                FileDTO fileDTO = new FileDTO(file);

                List<PropertyDTO> currentProperties = new List<PropertyDTO>();
                var properties = await client.GetFilePropertiesAsync(file.Id);
                foreach(var property in properties)
                {
                    PropertyDTO propertyDTO = new PropertyDTO(property);
                    currentProperties.Add(propertyDTO);
                }
                this.Files.Add(fileDTO);
                filePropertyDictionary.Add(fileDTO, currentProperties);
            }
        }
    }
}