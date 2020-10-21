using System.Collections.Generic;
using System.Threading.Tasks;
using P3.Challenge.FileSystemApp.Model;
using P3.Challenge.FileSystemApp.Model.Repositories;

namespace P3.Challenge.FileSystemApp.Repository
{
    public class FolderRepository : RepositoryBase<Folder, int>, IFolderRepository
    {
        public FolderRepository(P3DbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Folder>> GetSiblings(Folder root)
        {
            var siblings = new List<Folder>();

            var rootRef = await FindBy(f => f.Id == root.Id, i => i.SubFolders);

            if (rootRef.SubFolders == null) 
                return siblings;

            foreach (var subFolder in rootRef.SubFolders)
            {
                siblings.Add(subFolder);

                var children = await GetSiblings(subFolder);
                siblings.AddRange(children);
            }

            return siblings;
        }
    }
}
