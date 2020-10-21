using System.Collections.Generic;
using P3.Challenge.FileSystemApp.Messaging.File;

namespace P3.Challenge.FileSystemApp.Messaging.Folder
{
    public class FolderView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FolderView Parent { get; set; }
        public IEnumerable<FolderView> SubFolders { get; set; }
        public IEnumerable<FileView> Files { get; set; }
    }
}
