namespace P3.Challenge.FileSystemApp.Messaging.File
{
    public class CreateFileResponse : ResponseBase<CreateFileRequest>
    {
        public FileView File { get; set; }
    }
}
