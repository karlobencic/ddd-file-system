namespace P3.Challenge.FileSystemApp.Messaging.Folder
{
    public class CreateSubFolderRequest : RequestBase
    {
        public int ParentId { get; set; }
        public FolderCreateView NewFolder { get; set; }
    }
}
