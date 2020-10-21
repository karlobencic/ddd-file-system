using P3.Challenge.FileSystemApp.Messaging.Folder;

namespace P3.Challenge.FileSystemApp.Messaging.File
{
    public class FileView
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public FolderView Folder { get; set; }
    }
}
