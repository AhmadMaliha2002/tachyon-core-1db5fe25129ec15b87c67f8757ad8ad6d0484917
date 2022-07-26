using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TACHYON.Authorization.Permissions.Dto;

namespace TACHYON.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
