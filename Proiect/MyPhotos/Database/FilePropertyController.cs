using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;

namespace Database
{
    public class FilePropertyController
    {
        private DatabaseModelContainer Context;
        private FileController fileController;
        private PropertyController propertyController;

        public FilePropertyController()
        {
            Context = MyPhotosContext.GetContext();
            fileController = new FileController();
            propertyController = new PropertyController();
        }

        public FileProperty AddPropertyToFile(Guid fileId, Guid propertyId, string value)
        {
            FileProperty fp = new FileProperty()
            {
                Id = Guid.NewGuid(),
                FileId = fileId,
                PropertyId = propertyId,
                Value = value
            };

            Context.FileProperties.Add(fp);
            int added = Context.SaveChanges();
            if (added > 0) return fp;
            return null;
        }

        public FileProperty GetFileProperty(Guid fileId, Guid propertyId)
        {
            return Context.FileProperties.Where(fp => fp.FileId == fileId && fp.PropertyId == propertyId).FirstOrDefault();
        }

        public List<Property> GetFileProperties(Guid fileId)
        {
            List<Property> properties = new List<Property>();
            List<FileProperty> fileProperties = Context.FileProperties.Where(fp => fp.FileId == fileId).ToList();
            foreach (FileProperty fp in fileProperties)
            {
                Property p = propertyController.GetProperty(fp.PropertyId);
                if (p == null) return null;
                properties.Add(p);
            }
            return properties;
        }

        public List<File> GetFilesWithProperty(Guid propertyId)
        {
            return Context.FileProperties.
                Where(fp => fp.PropertyId == propertyId).
                Select(fp => fileController.GetFile(fp.FileId)).
                ToList();
        }

        public FileProperty UpdateValue(Guid fileId, Guid propertyId, string value)
        {
            FileProperty fp = GetFileProperty(fileId, propertyId);
            if (fp == null) return null;
            string dataType = propertyController.GetProperty(propertyId).DataType;
            if (IsValueValid(value, dataType))
            {
                fp.Value = value;
                int updated = Context.SaveChanges();
                if (updated > 0) return fp;
                return null;
            }
            return null;
        }

        public void RemoveProperty(Guid fileId, Guid propertyId)
        {
            FileProperty fp = GetFileProperty(fileId, propertyId);
            Context.FileProperties.Remove(fp);
            int deleted = Context.SaveChanges();

        }

        public static Boolean IsValueValid(string value, string dataType)
        {
            if (dataType == "string") return true;
            if (dataType == "date")
            {
                try
                {
                    System.DateTime newDate = DateTime.Parse(value);
                }
                catch (FormatException)
                {
                    return false;
                }
                return true;
            }
            if (dataType == "integer")
            {
                try
                {
                    int val = Int32.Parse(value);
                }
                catch (FormatException)
                {
                    return false;
                }
                return true;
            }
            if (dataType == "decimal")
            {
                try
                {
                    decimal val = Decimal.Parse(value);
                }
                catch (FormatException)
                {
                    return false;
                }
                return true;
            }
            return false;
        }


    }
}
