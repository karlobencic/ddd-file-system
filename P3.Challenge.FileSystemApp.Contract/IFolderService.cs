﻿using System.Threading.Tasks;
using P3.Challenge.FileSystemApp.Messaging.Folder;

namespace P3.Challenge.FileSystemApp.Contract
{
    public interface IFolderService
    {
        Task<GetFoldersResponse> GetAllFolders(GetFoldersRequest request);
        Task<CreateFolderResponse> CreateFolder(CreateFolderRequest request);
        Task<CreateSubFolderResponse> CreateSubFolder(CreateSubFolderRequest request);
        Task<DeleteFolderResponse> DeleteFolder(DeleteFolderRequest request);
    }
}
