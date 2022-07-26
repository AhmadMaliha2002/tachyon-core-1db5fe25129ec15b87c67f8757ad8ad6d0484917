using System.Collections.Generic;
using TACHYON.Auditing.Dto;
using TACHYON.Dto;

namespace TACHYON.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);

        FileDto ExportToFile(List<EntityChangeListDto> entityChangeListDtos);
    }
}
