using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
namespace HostedServiceTestService.ScheduleServices
{
    public class MailService : HostedService
    {
        protected override async Task ExecuteAsync(CancellationToken cToken)
        {
            while (!cToken.IsCancellationRequested)
            {
                //istek iptal edilmemiş ise mailleri gönder
                Debug.WriteLine($"{DateTime.Now.ToString(CultureInfo.InvariantCulture)} Mailler gönderiliyor.");
                //Her 10 saniyede bir bu işlemi yap
                await Task.Delay(TimeSpan.FromSeconds(10), cToken);
            }
        }
    }
}
