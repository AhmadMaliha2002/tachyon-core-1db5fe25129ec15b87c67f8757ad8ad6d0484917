using System.Collections.Generic;
using TACHYON.Authorization.Users.Importing.Dto;
using TACHYON.Dto;

namespace TACHYON.Authorization.Users.Importing
{
    public interface IInvalidUserExporter
    {
        FileDto ExportToFile(List<ImportUserDto> userListDtos);
    }
}
