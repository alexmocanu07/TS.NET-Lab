using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;

namespace Database
{
    public class PropertyController
    {
        private DatabaseModelContainer Context;

        public PropertyController()
        {
            Context = MyPhotosContext.GetContext();
            if (GetAllProperties().Count == 0) InitDefaultProperties();
        }

        public List<Property> InitDefaultProperties()
        {
            List<Property> defaultProperties = new List<Property>();


            Property location = new Property()
            {
                Id = Guid.NewGuid(),
                Name = "Location",
                DataType = "string",
                Description = "The location the picture/video was taken",
                Editable = false
            };

            Context.Properties.Add(location);
            defaultProperties.Add(location);

            Property person = new Property()
            {
                Id = Guid.NewGuid(),
                Name = "Person",
                DataType = "string",
                Description = "A person that is present in the picture/video",
                Editable = false
            };

            Context.Properties.Add(person);
            defaultProperties.Add(person);

            Property date = new Property()
            {
                Id = Guid.NewGuid(),
                Name = "Date",
                DataType = "date",
                Description = "The date the picture/video was taken",
                Editable = false
            };

            Context.Properties.Add(date);
            defaultProperties.Add(date);

            Property occasion = new Property()
            {
                Id = Guid.NewGuid(),
                Name = "Event",
                DataType = "string",
                Description = "The event the photo/video was taken at",
                Editable = false
            };

            Context.Properties.Add(occasion);
            defaultProperties.Add(occasion);

            Context.SaveChanges();

            return defaultProperties;
        }

        public Property CreateProperty(string name = null, string description = null, string dataType = null)
        {
            Property p = new Property() { Id = Guid.NewGuid(), Name = name, Description = description, DataType = dataType };
            Context.Properties.Add(p);
            int created = Context.SaveChanges();
            if (created > 0) return p;
            return null;
        }

        public List<Property> GetAllProperties()
        {
            return Context.Properties.ToList();
        }

        public Property GetProperty(Guid id)
        {
            return Context.Properties.FirstOrDefault(p => p.Id == id);
        }

        public Property GetPropertyByName(string name)
        {
            return Context.Properties.FirstOrDefault(p => p.Name == name);
        }

        public Property UpdateProperty(Guid id, string name = null, string description = null)
        {
            Property p = GetProperty(id);
            if (p != null && p.Editable)
            {
                p.Name = name ?? p.Name;
                p.Description = description ?? p.Description;
                int updated = Context.SaveChanges();
                if (updated > 0) return p;
            }
            return null;
        }

        public Property DeleteProperty(Guid id)
        {
            Property p = GetProperty(id);
            if (p != null && p.Editable)
            {
                Context.Properties.Remove(p);
                int deleted = Context.SaveChanges();
                if (deleted > 0) return p;
            }
            return null;
        }
    }
}
