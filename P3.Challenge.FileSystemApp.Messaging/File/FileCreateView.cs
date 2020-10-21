using System.ComponentModel.DataAnnotations;

namespace P3.Challenge.FileSystemApp.Messaging.File
{
    public class FileCreateView
    {
        [Required]
        public string Name { get; set; }
        [Required] 
        public int FolderId { get; set; }
    }
}