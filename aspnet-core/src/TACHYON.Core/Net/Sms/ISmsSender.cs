using System.Threading.Tasks;

namespace TACHYON.Net.Sms
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}