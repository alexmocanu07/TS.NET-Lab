﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="File", Namespace="http://schemas.datacontract.org/2004/07/Database", IsReference=true)]
    public partial class File : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private bool DeletedField;
        
        private Database.FileProperty[] FilePropertiesField;
        
        private System.Guid IdField;
        
        private string NameField;
        
        private string PathField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Deleted
        {
            get
            {
                return this.DeletedField;
            }
            set
            {
                this.DeletedField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Database.FileProperty[] FileProperties
        {
            get
            {
                return this.FilePropertiesField;
            }
            set
            {
                this.FilePropertiesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Path
        {
            get
            {
                return this.PathField;
            }
            set
            {
                this.PathField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FileProperty", Namespace="http://schemas.datacontract.org/2004/07/Database", IsReference=true)]
    public partial class FileProperty : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private Database.File FileField;
        
        private System.Guid FileIdField;
        
        private System.Guid IdField;
        
        private Database.Property PropertyField;
        
        private System.Guid PropertyIdField;
        
        private string ValueField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Database.File File
        {
            get
            {
                return this.FileField;
            }
            set
            {
                this.FileField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid FileId
        {
            get
            {
                return this.FileIdField;
            }
            set
            {
                this.FileIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Database.Property Property
        {
            get
            {
                return this.PropertyField;
            }
            set
            {
                this.PropertyField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid PropertyId
        {
            get
            {
                return this.PropertyIdField;
            }
            set
            {
                this.PropertyIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Value
        {
            get
            {
                return this.ValueField;
            }
            set
            {
                this.ValueField = value;
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Property", Namespace="http://schemas.datacontract.org/2004/07/Database", IsReference=true)]
    public partial class Property : object, System.Runtime.Serialization.IExtensibleDataObject
    {
        
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string DataTypeField;
        
        private string DescriptionField;
        
        private bool EditableField;
        
        private Database.FileProperty[] FilePropertiesField;
        
        private System.Guid IdField;
        
        private string NameField;
        
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DataType
        {
            get
            {
                return this.DataTypeField;
            }
            set
            {
                this.DataTypeField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Editable
        {
            get
            {
                return this.EditableField;
            }
            set
            {
                this.EditableField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Database.FileProperty[] FileProperties
        {
            get
            {
                return this.FilePropertiesField;
            }
            set
            {
                this.FilePropertiesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
}


[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
[System.ServiceModel.ServiceContractAttribute(ConfigurationName="IDatabase")]
public interface IDatabase
{
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/CreateFile", ReplyAction="http://tempuri.org/InterfaceFile/CreateFileResponse")]
    Database.File CreateFile(string path, string name);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/CreateFile", ReplyAction="http://tempuri.org/InterfaceFile/CreateFileResponse")]
    System.Threading.Tasks.Task<Database.File> CreateFileAsync(string path, string name);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/GetFile", ReplyAction="http://tempuri.org/InterfaceFile/GetFileResponse")]
    Database.File GetFile(System.Guid id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/GetFile", ReplyAction="http://tempuri.org/InterfaceFile/GetFileResponse")]
    System.Threading.Tasks.Task<Database.File> GetFileAsync(System.Guid id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/GetAllFiles", ReplyAction="http://tempuri.org/InterfaceFile/GetAllFilesResponse")]
    Database.File[] GetAllFiles();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/GetAllFiles", ReplyAction="http://tempuri.org/InterfaceFile/GetAllFilesResponse")]
    System.Threading.Tasks.Task<Database.File[]> GetAllFilesAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/GetFileByPath", ReplyAction="http://tempuri.org/InterfaceFile/GetFileByPathResponse")]
    Database.File GetFileByPath(string path);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/GetFileByPath", ReplyAction="http://tempuri.org/InterfaceFile/GetFileByPathResponse")]
    System.Threading.Tasks.Task<Database.File> GetFileByPathAsync(string path);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/GetFileByName", ReplyAction="http://tempuri.org/InterfaceFile/GetFileByNameResponse")]
    Database.File GetFileByName(string name);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/GetFileByName", ReplyAction="http://tempuri.org/InterfaceFile/GetFileByNameResponse")]
    System.Threading.Tasks.Task<Database.File> GetFileByNameAsync(string name);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/UpdateFile", ReplyAction="http://tempuri.org/InterfaceFile/UpdateFileResponse")]
    Database.File UpdateFile(System.Guid id, string name, string path);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/UpdateFile", ReplyAction="http://tempuri.org/InterfaceFile/UpdateFileResponse")]
    System.Threading.Tasks.Task<Database.File> UpdateFileAsync(System.Guid id, string name, string path);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/DeleteFile", ReplyAction="http://tempuri.org/InterfaceFile/DeleteFileResponse")]
    Database.File DeleteFile(System.Guid id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/DeleteFile", ReplyAction="http://tempuri.org/InterfaceFile/DeleteFileResponse")]
    System.Threading.Tasks.Task<Database.File> DeleteFileAsync(System.Guid id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/RemoveFile", ReplyAction="http://tempuri.org/InterfaceFile/RemoveFileResponse")]
    Database.File RemoveFile(System.Guid id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFile/RemoveFile", ReplyAction="http://tempuri.org/InterfaceFile/RemoveFileResponse")]
    System.Threading.Tasks.Task<Database.File> RemoveFileAsync(System.Guid id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceProperty/InitDefaultProperties", ReplyAction="http://tempuri.org/InterfaceProperty/InitDefaultPropertiesResponse")]
    Database.Property[] InitDefaultProperties();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceProperty/InitDefaultProperties", ReplyAction="http://tempuri.org/InterfaceProperty/InitDefaultPropertiesResponse")]
    System.Threading.Tasks.Task<Database.Property[]> InitDefaultPropertiesAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceProperty/CreateProperty", ReplyAction="http://tempuri.org/InterfaceProperty/CreatePropertyResponse")]
    Database.Property CreateProperty(string name, string description, string dataType);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceProperty/CreateProperty", ReplyAction="http://tempuri.org/InterfaceProperty/CreatePropertyResponse")]
    System.Threading.Tasks.Task<Database.Property> CreatePropertyAsync(string name, string description, string dataType);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceProperty/GetAllProperties", ReplyAction="http://tempuri.org/InterfaceProperty/GetAllPropertiesResponse")]
    Database.Property[] GetAllProperties();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceProperty/GetAllProperties", ReplyAction="http://tempuri.org/InterfaceProperty/GetAllPropertiesResponse")]
    System.Threading.Tasks.Task<Database.Property[]> GetAllPropertiesAsync();
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceProperty/GetProperty", ReplyAction="http://tempuri.org/InterfaceProperty/GetPropertyResponse")]
    Database.Property GetProperty(System.Guid id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceProperty/GetProperty", ReplyAction="http://tempuri.org/InterfaceProperty/GetPropertyResponse")]
    System.Threading.Tasks.Task<Database.Property> GetPropertyAsync(System.Guid id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceProperty/GetPropertyByName", ReplyAction="http://tempuri.org/InterfaceProperty/GetPropertyByNameResponse")]
    Database.Property GetPropertyByName(string name);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceProperty/GetPropertyByName", ReplyAction="http://tempuri.org/InterfaceProperty/GetPropertyByNameResponse")]
    System.Threading.Tasks.Task<Database.Property> GetPropertyByNameAsync(string name);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceProperty/UpdateProperty", ReplyAction="http://tempuri.org/InterfaceProperty/UpdatePropertyResponse")]
    Database.Property UpdateProperty(System.Guid id, string name, string description);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceProperty/UpdateProperty", ReplyAction="http://tempuri.org/InterfaceProperty/UpdatePropertyResponse")]
    System.Threading.Tasks.Task<Database.Property> UpdatePropertyAsync(System.Guid id, string name, string description);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceProperty/DeleteProperty", ReplyAction="http://tempuri.org/InterfaceProperty/DeletePropertyResponse")]
    Database.Property DeleteProperty(System.Guid id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceProperty/DeleteProperty", ReplyAction="http://tempuri.org/InterfaceProperty/DeletePropertyResponse")]
    System.Threading.Tasks.Task<Database.Property> DeletePropertyAsync(System.Guid id);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFileProperty/AddPropertyToFile", ReplyAction="http://tempuri.org/InterfaceFileProperty/AddPropertyToFileResponse")]
    Database.FileProperty AddPropertyToFile(System.Guid fileId, System.Guid propertyId, string value);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFileProperty/AddPropertyToFile", ReplyAction="http://tempuri.org/InterfaceFileProperty/AddPropertyToFileResponse")]
    System.Threading.Tasks.Task<Database.FileProperty> AddPropertyToFileAsync(System.Guid fileId, System.Guid propertyId, string value);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFileProperty/GetFileProperty", ReplyAction="http://tempuri.org/InterfaceFileProperty/GetFilePropertyResponse")]
    Database.FileProperty GetFileProperty(System.Guid fileId, System.Guid propertyId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFileProperty/GetFileProperty", ReplyAction="http://tempuri.org/InterfaceFileProperty/GetFilePropertyResponse")]
    System.Threading.Tasks.Task<Database.FileProperty> GetFilePropertyAsync(System.Guid fileId, System.Guid propertyId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFileProperty/GetFileProperties", ReplyAction="http://tempuri.org/InterfaceFileProperty/GetFilePropertiesResponse")]
    Database.Property[] GetFileProperties(System.Guid fileId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFileProperty/GetFileProperties", ReplyAction="http://tempuri.org/InterfaceFileProperty/GetFilePropertiesResponse")]
    System.Threading.Tasks.Task<Database.Property[]> GetFilePropertiesAsync(System.Guid fileId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFileProperty/GetFilesWithProperty", ReplyAction="http://tempuri.org/InterfaceFileProperty/GetFilesWithPropertyResponse")]
    Database.File[] GetFilesWithProperty(System.Guid propertyId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFileProperty/GetFilesWithProperty", ReplyAction="http://tempuri.org/InterfaceFileProperty/GetFilesWithPropertyResponse")]
    System.Threading.Tasks.Task<Database.File[]> GetFilesWithPropertyAsync(System.Guid propertyId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFileProperty/UpdateValue", ReplyAction="http://tempuri.org/InterfaceFileProperty/UpdateValueResponse")]
    Database.FileProperty UpdateValue(System.Guid fileId, System.Guid propertyId, string value);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFileProperty/UpdateValue", ReplyAction="http://tempuri.org/InterfaceFileProperty/UpdateValueResponse")]
    System.Threading.Tasks.Task<Database.FileProperty> UpdateValueAsync(System.Guid fileId, System.Guid propertyId, string value);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFileProperty/RemoveProperty", ReplyAction="http://tempuri.org/InterfaceFileProperty/RemovePropertyResponse")]
    void RemoveProperty(System.Guid fileId, System.Guid propertyId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFileProperty/RemoveProperty", ReplyAction="http://tempuri.org/InterfaceFileProperty/RemovePropertyResponse")]
    System.Threading.Tasks.Task RemovePropertyAsync(System.Guid fileId, System.Guid propertyId);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFileProperty/IsValueValid", ReplyAction="http://tempuri.org/InterfaceFileProperty/IsValueValidResponse")]
    bool IsValueValid(string value, string dataType);
    
    [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/InterfaceFileProperty/IsValueValid", ReplyAction="http://tempuri.org/InterfaceFileProperty/IsValueValidResponse")]
    System.Threading.Tasks.Task<bool> IsValueValidAsync(string value, string dataType);
}

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public interface IDatabaseChannel : IDatabase, System.ServiceModel.IClientChannel
{
}

[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
public partial class DatabaseClient : System.ServiceModel.ClientBase<IDatabase>, IDatabase
{
    
    public DatabaseClient()
    {
    }
    
    public DatabaseClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
    {
    }
    
    public DatabaseClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public DatabaseClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
    {
    }
    
    public DatabaseClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
    {
    }
    
    public Database.File CreateFile(string path, string name)
    {
        return base.Channel.CreateFile(path, name);
    }
    
    public System.Threading.Tasks.Task<Database.File> CreateFileAsync(string path, string name)
    {
        return base.Channel.CreateFileAsync(path, name);
    }
    
    public Database.File GetFile(System.Guid id)
    {
        return base.Channel.GetFile(id);
    }
    
    public System.Threading.Tasks.Task<Database.File> GetFileAsync(System.Guid id)
    {
        return base.Channel.GetFileAsync(id);
    }
    
    public Database.File[] GetAllFiles()
    {
        return base.Channel.GetAllFiles();
    }
    
    public System.Threading.Tasks.Task<Database.File[]> GetAllFilesAsync()
    {
        return base.Channel.GetAllFilesAsync();
    }
    
    public Database.File GetFileByPath(string path)
    {
        return base.Channel.GetFileByPath(path);
    }
    
    public System.Threading.Tasks.Task<Database.File> GetFileByPathAsync(string path)
    {
        return base.Channel.GetFileByPathAsync(path);
    }
    
    public Database.File GetFileByName(string name)
    {
        return base.Channel.GetFileByName(name);
    }
    
    public System.Threading.Tasks.Task<Database.File> GetFileByNameAsync(string name)
    {
        return base.Channel.GetFileByNameAsync(name);
    }
    
    public Database.File UpdateFile(System.Guid id, string name, string path)
    {
        return base.Channel.UpdateFile(id, name, path);
    }
    
    public System.Threading.Tasks.Task<Database.File> UpdateFileAsync(System.Guid id, string name, string path)
    {
        return base.Channel.UpdateFileAsync(id, name, path);
    }
    
    public Database.File DeleteFile(System.Guid id)
    {
        return base.Channel.DeleteFile(id);
    }
    
    public System.Threading.Tasks.Task<Database.File> DeleteFileAsync(System.Guid id)
    {
        return base.Channel.DeleteFileAsync(id);
    }
    
    public Database.File RemoveFile(System.Guid id)
    {
        return base.Channel.RemoveFile(id);
    }
    
    public System.Threading.Tasks.Task<Database.File> RemoveFileAsync(System.Guid id)
    {
        return base.Channel.RemoveFileAsync(id);
    }
    
    public Database.Property[] InitDefaultProperties()
    {
        return base.Channel.InitDefaultProperties();
    }
    
    public System.Threading.Tasks.Task<Database.Property[]> InitDefaultPropertiesAsync()
    {
        return base.Channel.InitDefaultPropertiesAsync();
    }
    
    public Database.Property CreateProperty(string name, string description, string dataType)
    {
        return base.Channel.CreateProperty(name, description, dataType);
    }
    
    public System.Threading.Tasks.Task<Database.Property> CreatePropertyAsync(string name, string description, string dataType)
    {
        return base.Channel.CreatePropertyAsync(name, description, dataType);
    }
    
    public Database.Property[] GetAllProperties()
    {
        return base.Channel.GetAllProperties();
    }
    
    public System.Threading.Tasks.Task<Database.Property[]> GetAllPropertiesAsync()
    {
        return base.Channel.GetAllPropertiesAsync();
    }
    
    public Database.Property GetProperty(System.Guid id)
    {
        return base.Channel.GetProperty(id);
    }
    
    public System.Threading.Tasks.Task<Database.Property> GetPropertyAsync(System.Guid id)
    {
        return base.Channel.GetPropertyAsync(id);
    }
    
    public Database.Property GetPropertyByName(string name)
    {
        return base.Channel.GetPropertyByName(name);
    }
    
    public System.Threading.Tasks.Task<Database.Property> GetPropertyByNameAsync(string name)
    {
        return base.Channel.GetPropertyByNameAsync(name);
    }
    
    public Database.Property UpdateProperty(System.Guid id, string name, string description)
    {
        return base.Channel.UpdateProperty(id, name, description);
    }
    
    public System.Threading.Tasks.Task<Database.Property> UpdatePropertyAsync(System.Guid id, string name, string description)
    {
        return base.Channel.UpdatePropertyAsync(id, name, description);
    }
    
    public Database.Property DeleteProperty(System.Guid id)
    {
        return base.Channel.DeleteProperty(id);
    }
    
    public System.Threading.Tasks.Task<Database.Property> DeletePropertyAsync(System.Guid id)
    {
        return base.Channel.DeletePropertyAsync(id);
    }
    
    public Database.FileProperty AddPropertyToFile(System.Guid fileId, System.Guid propertyId, string value)
    {
        return base.Channel.AddPropertyToFile(fileId, propertyId, value);
    }
    
    public System.Threading.Tasks.Task<Database.FileProperty> AddPropertyToFileAsync(System.Guid fileId, System.Guid propertyId, string value)
    {
        return base.Channel.AddPropertyToFileAsync(fileId, propertyId, value);
    }
    
    public Database.FileProperty GetFileProperty(System.Guid fileId, System.Guid propertyId)
    {
        return base.Channel.GetFileProperty(fileId, propertyId);
    }
    
    public System.Threading.Tasks.Task<Database.FileProperty> GetFilePropertyAsync(System.Guid fileId, System.Guid propertyId)
    {
        return base.Channel.GetFilePropertyAsync(fileId, propertyId);
    }
    
    public Database.Property[] GetFileProperties(System.Guid fileId)
    {
        return base.Channel.GetFileProperties(fileId);
    }
    
    public System.Threading.Tasks.Task<Database.Property[]> GetFilePropertiesAsync(System.Guid fileId)
    {
        return base.Channel.GetFilePropertiesAsync(fileId);
    }
    
    public Database.File[] GetFilesWithProperty(System.Guid propertyId)
    {
        return base.Channel.GetFilesWithProperty(propertyId);
    }
    
    public System.Threading.Tasks.Task<Database.File[]> GetFilesWithPropertyAsync(System.Guid propertyId)
    {
        return base.Channel.GetFilesWithPropertyAsync(propertyId);
    }
    
    public Database.FileProperty UpdateValue(System.Guid fileId, System.Guid propertyId, string value)
    {
        return base.Channel.UpdateValue(fileId, propertyId, value);
    }
    
    public System.Threading.Tasks.Task<Database.FileProperty> UpdateValueAsync(System.Guid fileId, System.Guid propertyId, string value)
    {
        return base.Channel.UpdateValueAsync(fileId, propertyId, value);
    }
    
    public void RemoveProperty(System.Guid fileId, System.Guid propertyId)
    {
        base.Channel.RemoveProperty(fileId, propertyId);
    }
    
    public System.Threading.Tasks.Task RemovePropertyAsync(System.Guid fileId, System.Guid propertyId)
    {
        return base.Channel.RemovePropertyAsync(fileId, propertyId);
    }
    
    public bool IsValueValid(string value, string dataType)
    {
        return base.Channel.IsValueValid(value, dataType);
    }
    
    public System.Threading.Tasks.Task<bool> IsValueValidAsync(string value, string dataType)
    {
        return base.Channel.IsValueValidAsync(value, dataType);
    }
}
