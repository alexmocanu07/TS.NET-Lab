using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;

namespace Database
{
    public class FileController
    {
        private DatabaseModelContainer Context;

        public FileController()
        {
            Context = MyPhotosContext.GetContext();
        }

        public File CreateFile(string path, string name = null)
        {
            File newFile = new File() { Id = Guid.NewGuid(), Path = path, Name = name == null ? "" : name };
            Context.Files.Add(newFile);
            int added = Context.SaveChanges();
            if (added > 0) return newFile;
            return null;
        }

        public File GetFile(Guid id)
        {
            return Context.Files.FirstOrDefault(f => f.Id == id);
        }

        public List<File> GetAllFiles()
        {
            return Context.Files.ToList();
        }
        public File GetFileByPath(string path)
        {
            return Context.Files.FirstOrDefault(f => f.Path == path);
        }

        public File GetFileByName(string name)
        {
            return Context.Files.FirstOrDefault(f => f.Name == name);
        }

        public File UpdateFile(Guid id, string name = null, string path = null)
        {
            File f = GetFile(id);
            f.Path = path ?? f.Path;
            f.Name = name ?? f.Name;

            int updated = Context.SaveChanges();
            if (updated > 0) return f;
            return null;
        }

        public File DeleteFile(Guid id)
        {
            File f = GetFile(id);
            f.Deleted = true;
            int deleted = Context.SaveChanges();
            if (deleted > 0) return f;
            return null;
        }

        public File RemoveFile(Guid id)
        {
            File f = GetFile(id);
            Context.Files.Remove(f);
            int removed = Context.SaveChanges();
            if (removed > 0) return null;
            return f;
        }


    }
}
