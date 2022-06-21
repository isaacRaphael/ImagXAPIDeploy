using ImagXAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImagXAPI.Contracts
{
    public interface ISharingKeyRepository : IGenericRepository<SharingKey>
    {
        Task<bool> Exists(string key);
    }
}
