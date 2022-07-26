using System.Collections.Generic;
using TACHYON.Authorization.Users.Dto;
using TACHYON.Dto;

namespace TACHYON.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}