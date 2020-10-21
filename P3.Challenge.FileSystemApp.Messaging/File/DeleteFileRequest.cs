namespace P3.Challenge.FileSystemApp.Messaging.File
{
    public class DeleteFileRequest : RequestBase
    {
        public int FolderId { get; set; }
        public int FileId { get; set; }
    }
}
