using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Database;
namespace ObjectWCF
{
    [ServiceContract]
    interface InterfaceFile
    {
        [OperationContract]
        File CreateFile(string path, string name = null);
        [OperationContract]
        File GetFile(Guid id);
        [OperationContract]
        List<File> GetAllFiles();
        [OperationContract]
        File GetFileByPath(string path);
        [OperationContract]
        File GetFileByName(string name);
        [OperationContract]
        File UpdateFile(Guid id, string name = null, string path = null);
        [OperationContract]
        File DeleteFile(Guid id);
        [OperationContract]
        File RemoveFile(Guid id);

    }

    [ServiceContract]
    interface InterfaceProperty
    {
        [OperationContract]
        List<Property> InitDefaultProperties();
        [OperationContract]
        Property CreateProperty(string name = null, string description = null, string dataType = null);
        [OperationContract]
        List<Property> GetAllProperties();
        [OperationContract]
        Property GetProperty(Guid id);
        [OperationContract]
        Property GetPropertyByName(string name);
        [OperationContract]
        Property UpdateProperty(Guid id, string name = null, string description = null);
        [OperationContract]
        Property DeleteProperty(Guid id);

    }

    [ServiceContract]
    interface InterfaceFileProperty
    {
        [OperationContract]
        FileProperty AddPropertyToFile(Guid fileId, Guid propertyId, string value);
        [OperationContract]
        FileProperty GetFileProperty(Guid fileId, Guid propertyId);
        [OperationContract]
        List<Property> GetFileProperties(Guid fileId);
        [OperationContract]
        List<File> GetFilesWithProperty(Guid propertyId);
        [OperationContract]
        FileProperty UpdateValue(Guid fileId, Guid propertyId, string value);
        [OperationContract]
        void RemoveProperty(Guid fileId, Guid propertyId);
        [OperationContract]
        Boolean IsValueValid(string value, string dataType);
    }

    [ServiceContract]
    interface IDatabase : InterfaceFile, InterfaceProperty, InterfaceFileProperty { }
}
