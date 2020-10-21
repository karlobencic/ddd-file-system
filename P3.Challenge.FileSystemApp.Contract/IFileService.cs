using System.Threading.Tasks;
using P3.Challenge.FileSystemApp.Messaging.File;

namespace P3.Challenge.FileSystemApp.Contract
{
    public interface IFileService
    {
        Task<GetFilesResponse> GetFiles(GetFilesRequest request);
        Task<CreateFileResponse> CreateFile(CreateFileRequest request);
        Task<SearchFilesResponse> SearchFiles(SearchFilesRequest request);
        Task<DeleteFileResponse> DeleteFile(DeleteFileRequest request);
    }
}
