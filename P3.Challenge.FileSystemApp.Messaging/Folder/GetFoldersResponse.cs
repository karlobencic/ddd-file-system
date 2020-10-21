using System.Collections.Generic;

namespace P3.Challenge.FileSystemApp.Messaging.Folder
{
    public class GetFoldersResponse : ResponseBase<GetFoldersRequest>
    {
        public IEnumerable<FolderView> Folders { get; set; }
    }
}
