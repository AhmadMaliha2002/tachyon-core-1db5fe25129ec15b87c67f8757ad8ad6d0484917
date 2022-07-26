using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using TACHYON.MultiTenancy.Accounting.Dto;

namespace TACHYON.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
