using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database;

namespace ObjectWCF
{
    public class DatabaseWCF : IDatabase
    {
        private FileController fileController = new FileController();
        private PropertyController propertyController = new PropertyController();
        private FilePropertyController filePropertyController = new FilePropertyController();

        public FileProperty AddPropertyToFile(Guid fileId, Guid propertyId, string value)
        {
            return filePropertyController.AddPropertyToFile(fileId, propertyId, value);
        }

        public File CreateFile(string path, string name = null)
        {
            return fileController.CreateFile(path, name);
        }

        public Property CreateProperty(string name = null, string description = null, string dataType = null)
        {
            return propertyController.CreateProperty(name, description, dataType);
        }

        public File DeleteFile(Guid id)
        {
            return fileController.DeleteFile(id);
        }

        public Property DeleteProperty(Guid id)
        {
            return propertyController.DeleteProperty(id);
        }

        public List<File> GetAllFiles()
        {
            return fileController.GetAllFiles();
        }

        public List<Property> GetAllProperties()
        {
            return propertyController.GetAllProperties();
        }

        public File GetFile(Guid id)
        {
            return fileController.GetFile(id);
        }

        public File GetFileByName(string name)
        {
            return fileController.GetFileByName(name);
        }

        public File GetFileByPath(string path)
        {
            return fileController.GetFileByPath(path);
        }

        public List<Property> GetFileProperties(Guid fileId)
        {
            return filePropertyController.GetFileProperties(fileId);
        }

        public FileProperty GetFileProperty(Guid fileId, Guid propertyId)
        {
            return filePropertyController.GetFileProperty(fileId, propertyId);
        }

        public List<File> GetFilesWithProperty(Guid propertyId)
        {
            return filePropertyController.GetFilesWithProperty(propertyId);
        }

        public Property GetProperty(Guid id)
        {
            return propertyController.GetProperty(id);
        }

        public Property GetPropertyByName(string name)
        {
            return propertyController.GetPropertyByName(name);
        }

        public List<Property> InitDefaultProperties()
        {
            return propertyController.InitDefaultProperties();
        }

        public bool IsValueValid(string value, string dataType)
        {
            return FilePropertyController.IsValueValid(value, dataType);
        }

        public File RemoveFile(Guid id)
        {
            return fileController.RemoveFile(id);
        }

        public void RemoveProperty(Guid fileId, Guid propertyId)
        {
            filePropertyController.RemoveProperty(fileId, propertyId);
        }

        public File UpdateFile(Guid id, string name = null, string path = null)
        {
            return fileController.UpdateFile(id, name, path);
        }

        public Property UpdateProperty(Guid id, string name = null, string description = null)
        {
            return propertyController.UpdateProperty(id, name, description);
        }

        public FileProperty UpdateValue(Guid fileId, Guid propertyId, string value)
        {
            return filePropertyController.UpdateValue(fileId, propertyId, value);
        }
    }
}
