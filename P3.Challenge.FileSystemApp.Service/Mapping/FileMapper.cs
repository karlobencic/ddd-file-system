using System.Collections.Generic;
using AutoMapper;
using P3.Challenge.FileSystemApp.Messaging.File;
using P3.Challenge.FileSystemApp.Model;

namespace P3.Challenge.FileSystemApp.Service.Mapping
{
    public static class FileMapper
    {
        #region Model => View

        public static FileView MapToView(this File model, IMapper mapper)
        {
            return mapper.Map<File, FileView>(model);
        }

        public static IEnumerable<FileView> MapToView(this IEnumerable<File> model, IMapper mapper)
        {
            return mapper.Map<IEnumerable<File>, IEnumerable<FileView>>(model);
        }

        #endregion

        #region View => Model

        public static File MapToModel(this FileCreateView view, IMapper mapper)
        {
            return mapper.Map<FileCreateView, File>(view);
        }

        #endregion
    }
}