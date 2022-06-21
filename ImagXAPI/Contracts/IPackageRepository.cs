using ImagXAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagXAPI.Contracts
{
    public interface IPackageRepository : IGenericRepository<Package>
    {
        Task<ICollection<Package>> RetrieveUserPackages(string userId);
    }
}
