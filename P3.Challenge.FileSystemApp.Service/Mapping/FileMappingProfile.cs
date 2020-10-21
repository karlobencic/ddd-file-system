using AutoMapper;
using P3.Challenge.FileSystemApp.Messaging.File;
using P3.Challenge.FileSystemApp.Model;

namespace P3.Challenge.FileSystemApp.Service.Mapping
{
    public class FileMappingProfile : Profile
    {
        public FileMappingProfile()
        {
            CreateMap<File, FileView>();
            CreateMap<FileCreateView, File>();
        }
    }
}