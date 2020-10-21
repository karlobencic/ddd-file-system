using P3.Challenge.FileSystemApp.Domain;

namespace P3.Challenge.FileSystemApp.Model
{
    public class File : EntityBase<int>
    {
        public string Name { get; set; }
        public int FolderId { get; set; }

        public virtual Folder Folder { get; set; }

        private File()
        {
        }
    }
}
