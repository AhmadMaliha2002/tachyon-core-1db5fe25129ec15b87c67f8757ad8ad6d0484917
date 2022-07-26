using System.Collections.Generic;
using System.Threading.Tasks;
using Abp;
using TACHYON.Dto;

namespace TACHYON.Gdpr
{
    public interface IUserCollectedDataProvider
    {
        Task<List<FileDto>> GetFiles(UserIdentifier user);
    }
}
