namespace P3.Challenge.FileSystemApp.Messaging.Folder
{
    public class CreateFolderResponse : ResponseBase<CreateFolderRequest>
    {
        public FolderView Folder { get; set; }
    }
}
