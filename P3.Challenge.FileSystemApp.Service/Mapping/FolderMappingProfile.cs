using AutoMapper;
using P3.Challenge.FileSystemApp.Messaging.Folder;
using P3.Challenge.FileSystemApp.Model;

namespace P3.Challenge.FileSystemApp.Service.Mapping
{
    public class FolderMappingProfile : Profile
    {
        public FolderMappingProfile()
        {
            CreateMap<Folder, FolderView>();
            CreateMap<FolderCreateView, Folder>();
        }
    }
}
