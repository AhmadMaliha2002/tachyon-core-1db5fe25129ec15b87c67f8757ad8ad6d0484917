using System.Collections.Generic;
using TACHYON.Authorization.Permissions.Dto;

namespace TACHYON.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}