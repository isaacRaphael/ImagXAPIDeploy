using ImagXAPI.Contracts;
using ImagXAPI.Data;
using ImagXAPI.Entities;

namespace ImagXAPI.Repositories
{
    public class PackageImageRepository : GenericRepository<PackageImage>, IPackageImageRepository
    {
        public PackageImageRepository(AppDbContext context) : base(context)
        {

        }
    }
}
