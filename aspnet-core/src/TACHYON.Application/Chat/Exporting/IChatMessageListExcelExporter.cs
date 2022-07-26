using System.Collections.Generic;
using Abp;
using TACHYON.Chat.Dto;
using TACHYON.Dto;

namespace TACHYON.Chat.Exporting
{
    public interface IChatMessageListExcelExporter
    {
        FileDto ExportToFile(UserIdentifier user, List<ChatMessageExportDto> messages);
    }
}
