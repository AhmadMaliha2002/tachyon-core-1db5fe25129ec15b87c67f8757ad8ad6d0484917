using System.Collections.Generic;
using TACHYON.Authorization.Users.Importing.Dto;
using Abp.Dependency;

namespace TACHYON.Authorization.Users.Importing
{
    public interface IUserListExcelDataReader: ITransientDependency
    {
        List<ImportUserDto> GetUsersFromExcel(byte[] fileBytes);
    }
}
