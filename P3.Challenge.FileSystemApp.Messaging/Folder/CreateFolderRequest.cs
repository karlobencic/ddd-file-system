namespace P3.Challenge.FileSystemApp.Messaging.Folder
{
    public class CreateFolderRequest : RequestBase
    {
        public FolderCreateView NewFolder { get; set; }
    }
}
