using System.Threading.Tasks;
using TACHYON.Sessions.Dto;

namespace TACHYON.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
