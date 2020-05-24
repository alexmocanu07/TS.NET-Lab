using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferenceMyPhotos;
using MyPhotosWebApp.Models;
using Microsoft.AspNetCore.Authentication.OAuth.Claims;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MyPhotosWebApp.Pages.Files
{
    public class IndexModel : PageModel
    {
        public List<FileDTO> Files { get; set; }
        public List<FilePropertyDTO> FileProperties { get; set; }
        public List<PropertyDTO> Properties { get; set; }
        public Dictionary<FileDTO, List<PropertyDTO>> filePropertyDictionary;
        public DatabaseClient client = new DatabaseClient();
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList propertyNames { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchProperty { get; set; }
        public int resultCount { get; set; }
        public IndexModel()
        {
            Files = new List<FileDTO>();
            FileProperties = new List<FilePropertyDTO>();
            Properties = new List<PropertyDTO>();
            filePropertyDictionary = new Dictionary<FileDTO, List<PropertyDTO>>();
            resultCount = 0;
        }
        public async Task OnGetAsync()
        {
            if (!string.IsNullOrEmpty(SearchString))
            {

            }
            List<string> propNames = new List<string>();
            var props = await client.GetAllPropertiesAsync();
            foreach(var prop in props)
            {
                propNames.Add(prop.Name);
            }
            propertyNames = new SelectList(propNames);
            var files = await client.GetAllFilesAsync();
            foreach(var file in files)
            {
                FileDTO fileDTO = new FileDTO(file);

                List<PropertyDTO> currentProperties = new List<PropertyDTO>();
                var properties = await client.GetFilePropertiesAsync(file.Id);
                bool toAdd = false;
                foreach(var property in properties)
                {
                    PropertyDTO propertyDTO = new PropertyDTO(property);
                    currentProperties.Add(propertyDTO);
                    if (!string.IsNullOrEmpty(SearchProperty))
                    {
                        if (propertyDTO.Name == SearchProperty)
                            toAdd = true;
                    }
                    else
                        toAdd = true;
                }
                if (toAdd)
                {
                    resultCount++;
                    this.Files.Add(fileDTO);
                    filePropertyDictionary.Add(fileDTO, currentProperties);
                }
            }
        }
    }
}