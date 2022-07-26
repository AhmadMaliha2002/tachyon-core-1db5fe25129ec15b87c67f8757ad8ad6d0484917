using Abp.Auditing;
using TACHYON.Configuration.Dto;

namespace TACHYON.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}