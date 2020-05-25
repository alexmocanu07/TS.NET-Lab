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
        public DatabaseClient client = new DatabaseClient();
        public SelectList propertyNames { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchProperty { get; set; }
        public int resultCount { get; set; }
        public IndexModel()
        {
            Files = new List<FileDTO>();
            resultCount = 0;
        }
        public async Task OnGetAsync()
        {
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

                var properties = await client.GetFilePropertiesAsync(file.Id);
                bool toAdd = false;
                foreach(var property in properties)
                {
                    PropertyDTO propertyDTO = new PropertyDTO(property);
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
                }
            }
        }
    }
}