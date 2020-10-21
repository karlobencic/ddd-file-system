using System.Collections.Generic;
using P3.Challenge.FileSystemApp.Domain;

namespace P3.Challenge.FileSystemApp.Model
{
    public class Folder : EntityBase<int>, IAggregateRoot
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }

        public virtual Folder Parent { get; set; }
        public virtual ICollection<Folder> SubFolders { get; set; }
        public virtual ICollection<File> Files { get; set; }

        private Folder()
        {
        }

        public void AddFile(File file)
        {
            if (Files == null)
            {
                Files = new List<File>
                {
                    file
                };
            }
            else
            {
                Files.Add(file);
            }
        }

        public void RemoveFile(File file)
        {
            Files.Remove(file);
        }

        public void SetParent(Folder folder)
        {
            Parent = folder;
        }
    }
}
