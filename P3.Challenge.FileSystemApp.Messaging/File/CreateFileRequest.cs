namespace P3.Challenge.FileSystemApp.Messaging.File
{
    public class CreateFileRequest : RequestBase
    {
        public FileCreateView NewFile { get; set; }
    }
}
