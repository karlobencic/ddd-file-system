namespace P3.Challenge.FileSystemApp.Messaging.Folder
{
    public class CreateSubFolderResponse : ResponseBase<CreateSubFolderRequest>
    {
        public FolderView SubFolder { get; set; }
    }
}
