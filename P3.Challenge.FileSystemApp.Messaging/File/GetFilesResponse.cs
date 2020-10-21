using System.Collections.Generic;

namespace P3.Challenge.FileSystemApp.Messaging.File
{
    public class GetFilesResponse : ResponseBase<GetFilesRequest>
    {
        public IEnumerable<FileView> Files { get; set; }
    }
}
