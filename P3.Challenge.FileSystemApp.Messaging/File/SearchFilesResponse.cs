using System.Collections.Generic;

namespace P3.Challenge.FileSystemApp.Messaging.File
{
    public class SearchFilesResponse : ResponseBase<SearchFilesRequest>
    {
        public IEnumerable<FileView> Files { get; set; }
    }
}
