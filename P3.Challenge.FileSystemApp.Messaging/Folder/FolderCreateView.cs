using System.ComponentModel.DataAnnotations;

namespace P3.Challenge.FileSystemApp.Messaging.Folder
{
    public class FolderCreateView
    {
        [Required]
        public string Name { get; set; }
    }
}
