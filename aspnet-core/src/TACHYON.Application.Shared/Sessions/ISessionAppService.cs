using System.Threading.Tasks;
using Abp.Application.Services;
using TACHYON.Sessions.Dto;

namespace TACHYON.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
