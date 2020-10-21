using System.Collections.Generic;
using System.Threading.Tasks;
using P3.Challenge.FileSystemApp.Domain;

namespace P3.Challenge.FileSystemApp.Model.Repositories
{
    public interface IFolderRepository : IRepository<Folder, string>
    {
        Task<IEnumerable<Folder>> GetSiblings(Folder root);
    }
}
