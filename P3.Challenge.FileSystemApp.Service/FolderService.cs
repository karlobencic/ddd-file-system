using System;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using P3.Challenge.FileSystemApp.Contract;
using P3.Challenge.FileSystemApp.Messaging.Folder;
using P3.Challenge.FileSystemApp.Model.Repositories;
using P3.Challenge.FileSystemApp.Service.Mapping;

namespace P3.Challenge.FileSystemApp.Service
{
    public class FolderService : ServiceBase, IFolderService
    {
        private readonly IFolderRepository _repository;
        private readonly IMapper _mapper;
        private readonly ILogger<IFolderService> _logger;

        public FolderService(IFolderRepository repository, IMapper mapper, ILogger<IFolderService> logger)
        {
            _repository = repository;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<GetFoldersResponse> GetAllFolders(GetFoldersRequest request)
        {
            var response = new GetFoldersResponse
            {
                Request = request,
                ResponseToken = Guid.NewGuid()
            };

            try
            {
                var folders = await _repository.FindAll
                    (
                        i => i.Parent, 
                        i => i.Files, 
                        i => i.SubFolders
                    );

                if (folders == null)
                {
                    return ContentNotFound<GetFoldersRequest, GetFoldersResponse>(response);
                }

                response.Folders = folders.MapToView(_mapper);
                response.Success = true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                response = GenericException<GetFoldersRequest, GetFoldersResponse>(response);
            }

            return response;
        }

        public async Task<CreateFolderResponse> CreateFolder(CreateFolderRequest request)
        {
            var response = new CreateFolderResponse
            {
                Request = request,
                ResponseToken = Guid.NewGuid()
            };

            try
            {
                var folder = request.NewFolder.MapToModel(_mapper);

                await _repository.Add(folder);

                response.Folder = folder.MapToView(_mapper);
                response.Success = true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                response = GenericException<CreateFolderRequest, CreateFolderResponse>(response);
            }

            return response;
        }

        public async Task<CreateSubFolderResponse> CreateSubFolder(CreateSubFolderRequest request)
        {
            var response = new CreateSubFolderResponse
            {
                Request = request,
                ResponseToken = Guid.NewGuid()
            };

            try
            {
                var parent = await _repository.FindBy
                    (
                        f => f.Id == request.ParentId, 
                        i => i.Parent,
                        i => i.SubFolders
                    );

                if (parent == null)
                {
                    return ResourceNotFound<CreateSubFolderRequest, CreateSubFolderResponse>(response);
                }

                var subFolder = request.NewFolder.MapToModel(_mapper);

                subFolder.SetParent(parent);

                await _repository.Add(subFolder);

                response.SubFolder = subFolder.MapToView(_mapper);
                response.Success = true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                response = GenericException<CreateSubFolderRequest, CreateSubFolderResponse>(response);
            }

            return response;
        }

        public async Task<DeleteFolderResponse> DeleteFolder(DeleteFolderRequest request)
        {
            var response = new DeleteFolderResponse
            {
                Request = request,
                ResponseToken = Guid.NewGuid()
            };

            try
            {
                var folder = await _repository.FindBy
                (
                    f => f.Id == request.Id,
                    i => i.Parent,
                    i => i.Files,
                    i => i.SubFolders
                );

                if (folder == null)
                {
                    return ResourceNotFound<DeleteFolderRequest, DeleteFolderResponse>(response);
                }

                var siblings = await _repository.GetSiblings(folder);

                await _repository.RemoveRange(siblings);
                await _repository.Remove(folder);

                response.Success = true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                response = GenericException<DeleteFolderRequest, DeleteFolderResponse>(response);
            }

            return response;
        }
    }
}
